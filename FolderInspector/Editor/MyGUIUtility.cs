using UnityEngine;
using UnityEditor;
using System.Collections;

public class MyGUIUtility
{

    static public void SplitLine(bool bEnable)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.white;
        }

        GUILayout.Box(GUIContent.none, MyGUIStyles.EditorLine, GUILayout.ExpandWidth(true), GUILayout.Height(2f));
        GUI.color = tmpcolor;
    }

    static public void Toggle(ref bool bEnable, string strLabel, ref bool value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = EditorGUILayout.Toggle(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;

        SplitLine(bEnable);
    }


    static public void IntSlider(ref bool bEnable, string strLabel, ref int value, int min, int max)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        EditorGUILayout.PrefixLabel(strLabel);
        value = EditorGUILayout.IntSlider(value, min, max);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;
        SplitLine(bEnable);

    }

    
    static public void MinMaxSlider(ref bool bEnable, string strLabel, ref int start, ref int end)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUI.BeginChangeCheck();

        float f3 = (float)start;
        float f4 = (float)end;


        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        EditorGUILayout.PrefixLabel(strLabel);
        EditorGUILayout.MinMaxSlider(ref f3, ref f4, 0f, 10f, new GUILayoutOption[0]);
        EditorGUILayout.EndHorizontal();

        if (EditorGUI.EndChangeCheck())
        {
            start = Mathf.RoundToInt(f3);
            end = Mathf.RoundToInt(f4);
        }

        GUI.color = tmpcolor;

        SplitLine(bEnable);


    }

    static public void EnumPopup(ref bool bEnable, string strLabel, ref FilterMode value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (FilterMode)EditorGUILayout.EnumPopup(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;

        SplitLine(bEnable);

    }


    static public void EnumPopup(ref bool bEnable, string strLabel, ref TextureWrapMode value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (TextureWrapMode)EditorGUILayout.EnumPopup(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;

        SplitLine(bEnable);

    }


    static public void EnumPopup(ref bool bEnable, string strLabel, ref TextureImporterMipFilter value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (TextureImporterMipFilter)EditorGUILayout.EnumPopup(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;

        SplitLine(bEnable);

    }


    static public void EnumPopup(ref bool bEnable, string strLabel, ref SpriteImportMode value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (SpriteImportMode)EditorGUILayout.EnumPopup(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;

        SplitLine(bEnable);

    }

    static public void EnumPopup(ref bool bEnable, string strLabel, ref TextureImporterGenerateCubemap value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (TextureImporterGenerateCubemap)EditorGUILayout.EnumPopup(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;

        SplitLine(bEnable);

    }

    static public void EnumPopup(ref bool bEnable, string strLabel, ref TextureImporterNPOTScale value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (TextureImporterNPOTScale)EditorGUILayout.EnumPopup(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;

        SplitLine(bEnable);

    }

    static public void EnumPopup(ref bool bEnable, string strLabel, ref TextureImporterType value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (TextureImporterType)EditorGUILayout.EnumPopup(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;

        SplitLine(bEnable);

    }

    static public void EnumPopup(ref bool bEnable, string strLabel, ref ModelImporterMeshCompression value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (ModelImporterMeshCompression)EditorGUILayout.EnumPopup(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;
        SplitLine(bEnable);

    }


    static public void EnumPopup(ref bool bEnable, string strLabel, ref ModelImporterAnimationType value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (ModelImporterAnimationType)EditorGUILayout.EnumPopup(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;
        SplitLine(bEnable);

    }

    static public void EnumPopup(ref bool bEnable, string strLabel, ref ModelImporterGenerateAnimations value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (ModelImporterGenerateAnimations)EditorGUILayout.EnumPopup(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;
        SplitLine(bEnable);

    }

    static public void EnumPopup(ref bool bEnable, string strLabel, ref ModelImporterAnimationCompression value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (ModelImporterAnimationCompression)EditorGUILayout.EnumPopup(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;
        SplitLine(bEnable);

    }

    static public void EnumPopup(ref bool bEnable, string strLabel, ref double value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (double)EditorGUILayout.FloatField(strLabel, (float)value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;
        SplitLine(bEnable);

    }

    static public void EnumPopup(ref bool bEnable, string strLabel, ref int value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (int)EditorGUILayout.IntField(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;
        SplitLine(bEnable);

    }

    static public void EnumPopup(ref bool bEnable, string strLabel, ref ModelImporterTangentSpaceMode value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (ModelImporterTangentSpaceMode)EditorGUILayout.EnumPopup(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;
        SplitLine(bEnable);

    }

    static public void EnumPopup(ref bool bEnable, string strLabel, ref TextureImporterFormat value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (TextureImporterFormat)EditorGUILayout.EnumPopup(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;
        SplitLine(bEnable);

    }


    static public void EnumPopup(ref bool bEnable, string strLabel, ref AudioCompressionFormat value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (AudioCompressionFormat)EditorGUILayout.EnumPopup(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;
        SplitLine(bEnable);

    }

    
    static public void EnumPopup(ref bool bEnable, string strLabel, ref AudioSampleRateSetting value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (AudioSampleRateSetting)EditorGUILayout.EnumPopup(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;
        SplitLine(bEnable);
    }

    static public void EnumPopup(ref bool bEnable, string strLabel, ref AudioClipLoadType value)
    {
        Color tmpcolor = GUI.color;
        if (bEnable == true)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        EditorGUILayout.BeginHorizontal();
        bEnable = EditorGUILayout.Toggle(bEnable, GUILayout.MaxWidth(10));
        value = (AudioClipLoadType)EditorGUILayout.EnumPopup(strLabel, value);
        EditorGUILayout.EndHorizontal();

        GUI.color = tmpcolor;
        SplitLine(bEnable);

    }    

}
