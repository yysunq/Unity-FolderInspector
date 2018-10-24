using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;
using LitJson;

 public static class MyGUIStyles
{
	private static GUIStyle m_line = null;
	//constructor
	static MyGUIStyles()
	{
		m_line = new GUIStyle("box");
		m_line.border.top = m_line.border.bottom = 2;
		m_line.margin.top = m_line.margin.bottom = 2;
		m_line.padding.top = m_line.padding.bottom = 2;
	}
	public static GUIStyle EditorLine
	{
		get { return m_line; }
	}
}

[CustomEditor(typeof(UnityEngine.Object),true)]
public class FolderEditor : Editor 
{
	static int beginIndex = 0;

	public bool bModelImport        = true;
	public bool bTextureImport      = true;
    public bool bAudioImport = true;

    
	public bool bUtility            = true;

	
	public  TMImporterSetting setting = null;
	private TMImporterSetting oldsetting = null;

	string assetpath = string.Empty;
	public override void OnInspectorGUI()
	{
        base.OnInspectorGUI();
        beginIndex = Application.dataPath.Length - 6;

        if (target == null)
		{
			return;
		}

		assetpath = AssetDatabase.GetAssetPath(target);
		if (Directory.Exists(assetpath))
		{ 
			if (setting == null)
			{
				AssetImporter ai = AssetImporter.GetAtPath(assetpath);
				if (ai != null)
				{
					if (string.IsNullOrEmpty(ai.userData))
					{
						setting     = new TMImporterSetting();
					}
					else
					{
						try
						{
							setting = JsonMapper.ToObject<TMImporterSetting>(ai.userData);
						}
						catch
						{
							setting = new TMImporterSetting();
						}
					}
				}
				oldsetting = new TMImporterSetting(setting);
			}

			DrawDirectory(assetpath);
			
		}
		else
		{
			//Debug.Log("I am no extension file");
		}
		return;
	}

	static public void BeginContents(string style)
	{
		//GUI.color = Color.gray;

		GUILayout.BeginHorizontal();
		GUILayout.Space(15f);
		EditorGUILayout.BeginHorizontal(style, GUILayout.MinHeight(10f));
		GUILayout.BeginVertical();
		GUILayout.Space(2f);

		//GUI.color = Color.gray;
	}

	static public void EndContents()
	{
		GUILayout.Space(3f);
		GUILayout.EndVertical();
		EditorGUILayout.EndHorizontal();
		GUILayout.Space(3f);
		GUILayout.EndHorizontal();
		GUILayout.Space(3f);
	}

	public void DrawDirectory(string path)
	{
		GUI.enabled = true;
		EditorGUILayout.BeginVertical();
		setting.bEnableImportSetting = EditorGUILayout.BeginToggleGroup("  Enable Auto Import Setting", setting.bEnableImportSetting);
		if (setting.bEnableImportSetting)
		{
			bModelImport = EditorGUILayout.Foldout(bModelImport, "Mesh Auto Import Setting");
			if (bModelImport)
			{
				BeginContents("Window");
				setting.OnMeshGUI();
				EndContents();
			}

			bTextureImport = EditorGUILayout.Foldout(bTextureImport, "Texture Auto Import Setting");
			if (bTextureImport)
			{
				BeginContents("Window");
				setting.OnTextureGUI();
				EndContents();
			}

            bAudioImport = EditorGUILayout.Foldout(bAudioImport, "Audio Auto Import Setting");
            if (bAudioImport)
            {
                BeginContents("Window");
                setting.OnAudioGUI();
                EndContents();
            }

		}
		EditorGUILayout.EndToggleGroup();

		BeginContents("Box");
		if (setting.IsEqual(oldsetting) == false)
		{
			Color tmpcolor = GUI.color;
			GUI.color = Color.green;
			if (GUILayout.Button("Changed Apply And Saved"))
			{
				AssetImporter ai = AssetImporter.GetAtPath(assetpath);
				ai.userData = JsonMapper.ToJson(setting);
				AssetDatabase.ImportAsset(assetpath, ImportAssetOptions.ForceUpdate);
				DirectoryInfo dir = new DirectoryInfo(assetpath);
				enumResource(dir, setting);
				setting = null;
			}

            if (GUILayout.Button("Apply But Not Saved"))
            {
                DirectoryInfo dir = new DirectoryInfo(assetpath);
                enumResource(dir, setting, false);
                setting = null;
            }

            if (GUILayout.Button("Clean All"))
            {
                DirectoryInfo dir = new DirectoryInfo(assetpath);
                CleanDirSetting(dir);
                setting = null;
            }

			GUI.color = tmpcolor;
		}
		else
		{
			if (GUILayout.Button("Apply And Saved"))
			{
				AssetImporter ai = AssetImporter.GetAtPath(assetpath);
				ai.userData = JsonMapper.ToJson(setting);
				AssetDatabase.ImportAsset(assetpath, ImportAssetOptions.ForceUpdate);
				DirectoryInfo dir = new DirectoryInfo(assetpath);
				enumResource(dir, setting, true);
				setting = null;
			}

            if (GUILayout.Button("Apply But Not Saved"))
            {
                DirectoryInfo dir = new DirectoryInfo(assetpath);
                enumResource(dir, setting, false);
                setting = null;
            }

            if (GUILayout.Button("Clean All"))
            {
                DirectoryInfo dir = new DirectoryInfo(assetpath);
                CleanDirSetting(dir);
                setting = null;
            }

		}
		EndContents();
		EditorGUILayout.EndVertical();
	}

    static void CleanDirSetting(DirectoryInfo dir)
    {
        string dirpath = dir.FullName.Substring(beginIndex);
        AssetImporter ai = AssetImporter.GetAtPath(dirpath);
        if (ai != null)
        {
            ai.userData = string.Empty;
            AssetDatabase.ImportAsset(dirpath, ImportAssetOptions.ForceUpdate);
        }

        DirectoryInfo[] di = dir.GetDirectories();
        for (int i = 0; i < di.Length; i++)
        {
            CleanDirSetting(di[i]);
        }
    }

	static void enumResource(DirectoryInfo dir, TMImporterSetting setting, bool bNeedSave = true)
	{
		FileInfo[] fi = dir.GetFiles();
		DirectoryInfo[] di = dir.GetDirectories();
		for (int i = 0; i < fi.Length; i++)
		{
			HandleFile(fi[i], setting);
		}

		for (int i = 0; i < di.Length; i++)
		{
            if (bNeedSave)
            {
                HandleDir(di[i], setting);
            }
            enumResource(di[i], setting, bNeedSave);
		}
	}
	static void HandleDir(DirectoryInfo di, TMImporterSetting setting)
	{
		string dirpath = di.FullName.Substring(beginIndex);
		AssetImporter ai = AssetImporter.GetAtPath(dirpath);
		if (ai != null)
		{
			Debug.Log("dir=" + dirpath);
			ai.userData = JsonMapper.ToJson(setting);
			AssetDatabase.ImportAsset(dirpath, ImportAssetOptions.ForceUpdate);
		}
		else
		{
			Debug.LogError("ai == null");
		}
	}

	static void HandleTexture(string fp, TMImporterSetting setting)
	{
		if (string.IsNullOrEmpty(fp) == false && setting != null)
		{
			TextureImporter ti = AssetImporter.GetAtPath(fp) as TextureImporter;
			if (ti != null)
			{
				Debug.Log("file=" + fp);
				setting.HandleTexture(ti);
				AssetDatabase.ImportAsset(fp, ImportAssetOptions.ForceUpdate);
			}
		}
	}

	static void HandleAudio(string fp, TMImporterSetting setting)
    {
        if (string.IsNullOrEmpty(fp) == false && setting != null)
        {
            AudioImporter ai = AssetImporter.GetAtPath(fp) as AudioImporter;
            if (ai != null)
            {
                Debug.Log("file=" + fp);
                setting.HandleAudio(ai);
                AssetDatabase.ImportAsset(fp, ImportAssetOptions.ForceUpdate);
            }
        }
    }

	static void HandleMesh(string fp, TMImporterSetting setting)
	{
		if (string.IsNullOrEmpty(fp) == false && setting != null)
		{
			ModelImporter mi = AssetImporter.GetAtPath(fp) as ModelImporter;
			if (mi != null)
			{
				Debug.Log("file=" + fp);
				setting.HandleMesh(mi);
				AssetDatabase.ImportAsset(fp, ImportAssetOptions.ForceUpdate);
			}
		}
	}
	

	static void HandleFile(FileInfo fi, TMImporterSetting setting)
	{
		string filepath = fi.FullName.Substring(beginIndex);
		switch(fi.Extension.ToLower())
		{
			case ".png":
			case ".jpg":
			case ".tga":
			case ".exr":
				HandleTexture(filepath, setting);
				break;

			case ".fbx":
			case ".obj":
                HandleMesh(filepath, setting);
				break;
            
            case ".mp3":
            case ".ogg":
            case ".wav":
                HandleAudio(filepath, setting);
                break;

		}
	}
}
