using UnityEngine;
using UnityEditor;
using System.Collections;
using LitJson;
using System.IO;
public class AssetPostImportHander : AssetPostprocessor 
{
	public TMImporterSetting setting = null;

	static string GetMetaString(string pt)
	{
		if (string.IsNullOrEmpty(pt) == false)
		{
			AssetImporter ai = AssetImporter.GetAtPath(pt);
			if (ai != null)
			{
				if (string.IsNullOrEmpty(ai.userData) == false)
				{
					if (ai.userData != "null" && ai.userData != "Null")
					{
						return ai.userData;
					}
				}
			}
		}
		return string.Empty;
	}

	//递归寻找父目录节点的Meta数据
	static string FindMetaString(string pt)
	{
		if (string.IsNullOrEmpty(pt) == false)
		{
			if (Directory.Exists(pt))
			{
				//如果是目录，尝试取metadata
				string metadata = GetMetaString(pt);
				if (metadata != string.Empty)
				{
					return metadata;
				}
				else
				{
					string[] strPathLst = pt.Split(char.Parse("/"));
					if (strPathLst.Length > 1)
					{
						strPathLst[strPathLst.Length - 1] = string.Empty;
						string strTmpPath = string.Join("/", strPathLst);
						string strNewPath = strTmpPath.Substring(0, strTmpPath.Length - 1);
						return FindMetaString(strNewPath);
					}
					else
					{
						return string.Empty;
					}
				}
			}
		}
		return string.Empty;
	}

	static void OnPostprocessAllAssets (
			string[] importedAssets,
			string[] deletedAssets,
			string[] movedAssets,
			string[] movedFromAssetPaths)
	{
		for (int i = 0; i < importedAssets.Length; i++)
		{
			if (string.IsNullOrEmpty(importedAssets[i]) == false)
			{
				if (Directory.Exists(importedAssets[i]))
				{
					string metadata = FindMetaString(Path.GetDirectoryName(importedAssets[i]));
					AssetImporter ai = AssetImporter.GetAtPath(importedAssets[i]);
					if (ai != null)
					{
						if (string.IsNullOrEmpty(ai.userData))
						{
							ai.userData = metadata;
						}
					}
				}
			}
		}

		for (int i = 0; i < movedAssets.Length; i++)
		{
			if (string.IsNullOrEmpty(movedAssets[i]) == false)
			{
				Debug.Log("movedAssets[" + i + "]=" + movedAssets[i]);
				if (Directory.Exists(movedAssets[i]))
				{
					string metadata = FindMetaString(Path.GetDirectoryName(movedAssets[i]));
					AssetImporter ai = AssetImporter.GetAtPath(movedAssets[i]);
					if (ai != null)
					{
						if (string.IsNullOrEmpty(ai.userData))
						{
							ai.userData = metadata;
						}
					}
				}
				else
				{
					AssetImporter ai = AssetImporter.GetAtPath(movedAssets[i]);
					string typeName = ai.GetType().FullName;
					if (typeName == "UnityEditor.TextureImporter")
					{
						string metadata = FindMetaString(Path.GetDirectoryName(movedAssets[i]));
						if (string.IsNullOrEmpty(metadata) == false)
						{
//							Debug.Log("metadata=" + metadata);
							TMImporterSetting lsetting = null;
							try
							{
								lsetting = JsonMapper.ToObject<TMImporterSetting>(metadata);
							}
							catch
							{
								lsetting = new TMImporterSetting();
							}

							if (lsetting != null)
							{
								TextureImporter mi = ai as TextureImporter;
								lsetting.HandleTexture(mi);
							}
						}
					}
					else if (typeName == "UnityEditor.ModelImporter")
					{
						string metadata = FindMetaString(Path.GetDirectoryName(movedAssets[i]));
						if (string.IsNullOrEmpty(metadata) == false)
						{
//							Debug.Log("metadata=" + metadata);
							TMImporterSetting lsetting = null;
							try
							{
								lsetting = JsonMapper.ToObject<TMImporterSetting>(metadata);
							}
							catch
							{
								lsetting = new TMImporterSetting();
							}

							if (lsetting != null)
							{
								ModelImporter mi = ai as ModelImporter;
								lsetting.HandleMesh(mi);
							}
						}
					}
                    else if (typeName == "UnityEditor.AudioImporter")
                    {
                        string metadata = FindMetaString(Path.GetDirectoryName(movedAssets[i]));
                        if (string.IsNullOrEmpty(metadata) == false)
                        {
                            //							Debug.Log("metadata=" + metadata);
                            TMImporterSetting lsetting = null;
                            try
                            {
                                lsetting = JsonMapper.ToObject<TMImporterSetting>(metadata);
                            }
                            catch
                            {
                                lsetting = new TMImporterSetting();
                            }

                            if (lsetting != null)
                            {
                                AudioImporter Ai = ai as AudioImporter;
                                lsetting.HandleAudio(Ai);
                            }
                        }
                    }

				}
			}
		}


		for (int i = 0; i < movedFromAssetPaths.Length; i++)
		{
			if (string.IsNullOrEmpty(movedFromAssetPaths[i]) == false)
			{
				Debug.Log("movedFromAssetPaths[" + i + "]=" + movedFromAssetPaths[i]);
			}
		}
	}


    void OnPreprocessAudio()
    {
        string metadata = FindMetaString(Path.GetDirectoryName(assetPath));
        if (string.IsNullOrEmpty(metadata) == false)
        {
            //			Debug.Log("metadata=" + metadata);
            try
            {
                setting = JsonMapper.ToObject<TMImporterSetting>(metadata);
            }
            catch
            {
                setting = new TMImporterSetting();
            }

            if (setting != null)
            {
                AudioImporter ai = assetImporter as AudioImporter;
                setting.HandleAudio(ai);
            }
        }

    }

	void OnPreprocessTexture ()
	{
		string metadata = FindMetaString( Path.GetDirectoryName(assetPath));
		if (string.IsNullOrEmpty(metadata) == false)
		{
//			Debug.Log("metadata=" + metadata);
			try
			{
				setting = JsonMapper.ToObject<TMImporterSetting>(metadata);
			}
			catch
			{
				setting = new TMImporterSetting();
			}

			if (setting != null)
			{
				TextureImporter ti = assetImporter as TextureImporter;
				setting.HandleTexture(ti);
			}
		}
	}


	void OnPreprocessModel()
	{
		string metadata = FindMetaString(Path.GetDirectoryName(assetPath));
		if (string.IsNullOrEmpty(metadata) == false)
		{
//			Debug.Log("metadata=" + metadata);
			try
			{
				setting = JsonMapper.ToObject<TMImporterSetting>(metadata);
			}
			catch
			{
				setting = new TMImporterSetting();
			}

			if (setting != null)
			{
				ModelImporter mi = assetImporter as ModelImporter;
				setting.HandleMesh(mi);
			}
		}
	}

}
