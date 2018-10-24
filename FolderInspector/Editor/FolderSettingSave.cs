using UnityEngine;
using UnityEditor;
using System.Collections;

public class TMImporterSetting
{
    //通用属性
    public bool bEnableImportSetting = false;


    //texture属性
    public TextureImporterType Tex_ImporterType = TextureImporterType.Image;
    public bool bChanged_ImporterType = false;

    public SpriteImportMode Tex_SpriteImport    = SpriteImportMode.None;
    public bool bChanged_SpriteImport = false;

    public bool Tex_SetReadable                 = false;
    public bool bChanged_SetReadable = false;

    public TextureImporterGenerateCubemap Tex_generateCubemap = TextureImporterGenerateCubemap.None;
    public bool bChanged_generateCubemap = false;

    public FilterMode Tex_filterMode            = FilterMode.Bilinear;
    public bool bChanged_filterMode = false;

    public TextureWrapMode Tex_wrapMode         = TextureWrapMode.Repeat;
    public bool bChanged_wrapMode = false;

    public TextureImporterNPOTScale Tex_npotScale = TextureImporterNPOTScale.None;
    public bool bChanged_npotScale = false;

    public bool Tex_alphaIsTransparency         = false;
    public bool bChanged_alphaIsTransparency = false;

    public bool Tex_grayscaleToAlpha            = false;
    public bool bChanged_grayscaleToAlpha = false;

    public int Tex_anisoLevel                   = 1;
    public bool bChanged_anisoLevel = false;
    
    //mipmap
    public bool Tex_mipmapEnabled               = false;
    public bool bChanged_mipmapEnabled = false;

    public bool Tex_borderMipmap                = false;
    public bool bChanged_borderMipmap = false;

    public bool Tex_generateMipsInLinearSpace   = false;
    public bool bChanged_generateMipsInLinearSpace = false;

    public TextureImporterMipFilter Tex_mipmapFilter = TextureImporterMipFilter.BoxFilter;
    public bool bChanged_mipmapFilter = false;

    public bool Tex_fadeout                     = false;
    public bool bChanged_fadeout = false;

    public int  Tex_mipmapFadeDistanceEnd       = 3;
    public int  Tex_mipmapFadeDistanceStart     = 1;
    public bool bChanged_mipmapFadeDistance = false;

    public int Tex_Android_maxTextureSize = 1024;
    public bool bChanged_Tex_Android_maxTextureSize = false;

    public int Tex_IOS_maxTextureSize = 1024;
    public bool bChanged_Tex_IOS_maxTextureSize = false;

    public TextureImporterFormat Tex_Android_TextureImporterFormat = TextureImporterFormat.RGBA32;
    public bool bChanged_Tex_Android_TextureImporterFormat = false;

    public TextureImporterFormat Tex_IOS_TextureImporterFormat = TextureImporterFormat.RGBA32;
    public bool bChanged_Tex_IOS_TextureImporterFormat = false;

    //mesh属性
    public bool Mesh_Generate2uv       = false;
    public bool bChanged_Mesh_Generate2uv = false;

    public ModelImporterMeshCompression Mesh_ImporterCompression = ModelImporterMeshCompression.Off;
    public bool bChanged_Mesh_ImporterCompression = false;

    public bool Mesh_SetReadable       = false;
    public bool bChanged_Mesh_SetReadable = false;

    public bool Mesh_SetOptimizeMesh   = false;
    public bool bChanged_Mesh_SetOptimizeMesh = false;

    public ModelImporterAnimationType Mesh_SetAnimationType = ModelImporterAnimationType.Legacy;
    public bool bChanged_Mesh_SetAnimationType = false;

    public ModelImporterGenerateAnimations Mesh_SetGenerateAnimations = ModelImporterGenerateAnimations.InRoot;
    public bool bChanged_Mesh_SetGenerateAnimations = false;

    public ModelImporterAnimationCompression Mesh_SetModelImporterAnimationCompression = ModelImporterAnimationCompression.Off;
    public bool bChanged_Mesh_SetModelImporterAnimationCompression = false;

    public double Mesh_SetanimationPositionError = 0.5f;
    public bool bChanged_Mesh_SetanimationPositionError = false;

    public double Mesh_SetanimationRotationError = 0.5f;
    public bool bChanged_Mesh_SetanimationRotationError = false;

    public double Mesh_SetanimationScaleError = 0.5f;
    public bool bChanged_Mesh_SetanimationScaleError = false;

    public ModelImporterTangentSpaceMode Mesh_SetModelImporterTangentSpaceMode = ModelImporterTangentSpaceMode.None;
    public bool bChanged_Mesh_SetModelImporterTangentSpaceMode = false;

    //Audio属性
    public AudioCompressionFormat Audio_SetAudioCompressionFormat = AudioCompressionFormat.PCM;
    public bool bChanged_Audio_SetAudioCompressionFormat = false;

    public AudioClipLoadType Audio_SetAudioImporterLoadType = AudioClipLoadType.CompressedInMemory;
    public bool bChanged_Audio_SetAudioImporterLoadType = false;

    public AudioSampleRateSetting Audio_SetAudioSampleRateSetting = AudioSampleRateSetting.PreserveSampleRate;
    public bool bChanged_Audio_SetAudioSampleRateSetting = false;

    

    public TMImporterSetting()
    {
        bEnableImportSetting = false;

        Tex_ImporterType        = TextureImporterType.Image;
        Tex_SpriteImport        = SpriteImportMode.None;
        Tex_SetReadable         = false;
        Tex_generateCubemap     = TextureImporterGenerateCubemap.None;
        Tex_filterMode          = FilterMode.Bilinear;
        Tex_wrapMode            = TextureWrapMode.Repeat;
        Tex_npotScale           = TextureImporterNPOTScale.None;
        Tex_alphaIsTransparency = false;
        Tex_grayscaleToAlpha    = false;
        Tex_anisoLevel          = 1;

        Tex_mipmapEnabled       = false;
        Tex_borderMipmap        = false;
        Tex_generateMipsInLinearSpace   = false;
        Tex_mipmapFilter        = TextureImporterMipFilter.BoxFilter;
        Tex_fadeout             = false;
        Tex_mipmapFadeDistanceEnd       = 3;
        Tex_mipmapFadeDistanceStart     = 1;
        Tex_Android_maxTextureSize = 1024;
        Tex_IOS_maxTextureSize = 1024;
        Tex_Android_TextureImporterFormat = TextureImporterFormat.RGBA32;
        Tex_IOS_TextureImporterFormat = TextureImporterFormat.RGBA32;
    
        
        bChanged_ImporterType = false;
        bChanged_SpriteImport = false;
        bChanged_SetReadable = false;
        bChanged_generateCubemap = false;
        bChanged_filterMode = false;
        bChanged_wrapMode = false;
        bChanged_npotScale = false;
        bChanged_alphaIsTransparency = false;
        bChanged_grayscaleToAlpha = false;
        bChanged_anisoLevel = false;

        bChanged_mipmapEnabled = false;
        bChanged_borderMipmap = false;
        bChanged_generateMipsInLinearSpace = false;
        bChanged_mipmapFilter = false;
        bChanged_fadeout = false;
        bChanged_mipmapFadeDistance = false;
        bChanged_Tex_Android_maxTextureSize = false;
        bChanged_Tex_IOS_maxTextureSize = false;
        bChanged_Tex_Android_TextureImporterFormat = false;
        bChanged_Tex_IOS_TextureImporterFormat = false;

        


        Mesh_Generate2uv = false;
        Mesh_SetReadable = false;
        Mesh_SetOptimizeMesh = false;
        Mesh_ImporterCompression = ModelImporterMeshCompression.Off;
        Mesh_SetAnimationType = ModelImporterAnimationType.Legacy;
        Mesh_SetGenerateAnimations = ModelImporterGenerateAnimations.InRoot;
        Mesh_SetModelImporterAnimationCompression = ModelImporterAnimationCompression.Off;
        Mesh_SetModelImporterTangentSpaceMode = ModelImporterTangentSpaceMode.None;

        Mesh_SetanimationPositionError = 0.5f;
        Mesh_SetanimationRotationError = 0.5f;
        Mesh_SetanimationScaleError = 0.5f;

        
        bChanged_Mesh_SetAnimationType = false;
        bChanged_Mesh_SetGenerateAnimations = false;
        bChanged_Mesh_Generate2uv = false;
        bChanged_Mesh_SetReadable = false;
        bChanged_Mesh_SetOptimizeMesh = false;
        bChanged_Mesh_ImporterCompression = false;
        bChanged_Mesh_SetanimationPositionError = false;
        bChanged_Mesh_SetanimationRotationError = false;
        bChanged_Mesh_SetanimationScaleError = false;
        bChanged_Mesh_SetModelImporterAnimationCompression = false;
        bChanged_Mesh_SetModelImporterTangentSpaceMode = false;


        Audio_SetAudioCompressionFormat = AudioCompressionFormat.PCM;
        Audio_SetAudioImporterLoadType = AudioClipLoadType.CompressedInMemory;
        Audio_SetAudioSampleRateSetting = AudioSampleRateSetting.PreserveSampleRate;

        bChanged_Audio_SetAudioCompressionFormat = false;
        bChanged_Audio_SetAudioImporterLoadType = false;
        bChanged_Audio_SetAudioSampleRateSetting = false;


    }

    public TMImporterSetting(TMImporterSetting refer)
    {
        clone(refer);
    }

    public void clone(TMImporterSetting refer)
    {
        bEnableImportSetting = refer.bEnableImportSetting;

        Tex_ImporterType        = refer.Tex_ImporterType;
        Tex_SpriteImport        = refer.Tex_SpriteImport;
        Tex_SetReadable         = refer.Tex_SetReadable;
        Tex_generateCubemap     = refer.Tex_generateCubemap;
        Tex_filterMode          = refer.Tex_filterMode;
        Tex_wrapMode            = refer.Tex_wrapMode;
        Tex_npotScale           = refer.Tex_npotScale;
        Tex_alphaIsTransparency = refer.Tex_alphaIsTransparency;
        Tex_grayscaleToAlpha    = refer.Tex_grayscaleToAlpha;
        Tex_anisoLevel          = refer.Tex_anisoLevel;

        Tex_mipmapEnabled       = refer.Tex_mipmapEnabled;
        Tex_borderMipmap        = refer.Tex_borderMipmap;
        Tex_generateMipsInLinearSpace = refer.Tex_generateMipsInLinearSpace;
        Tex_mipmapFilter        = refer.Tex_mipmapFilter;
        Tex_fadeout             = refer.Tex_fadeout;
        Tex_mipmapFadeDistanceEnd = refer.Tex_mipmapFadeDistanceEnd;
        Tex_mipmapFadeDistanceStart = refer.Tex_mipmapFadeDistanceStart;
        Tex_Android_maxTextureSize = refer.Tex_Android_maxTextureSize;
        Tex_IOS_maxTextureSize = refer.Tex_IOS_maxTextureSize;
        Tex_Android_TextureImporterFormat = refer.Tex_Android_TextureImporterFormat;
        Tex_IOS_TextureImporterFormat = refer.Tex_IOS_TextureImporterFormat;

        bChanged_ImporterType = refer.bChanged_ImporterType;
        bChanged_SpriteImport = refer.bChanged_SpriteImport;
        bChanged_SetReadable = refer.bChanged_SetReadable;
        bChanged_generateCubemap = refer.bChanged_generateCubemap;
        bChanged_filterMode = refer.bChanged_filterMode;
        bChanged_wrapMode = refer.bChanged_wrapMode;
        bChanged_npotScale = refer.bChanged_npotScale;
        bChanged_alphaIsTransparency = refer.bChanged_alphaIsTransparency;
        bChanged_grayscaleToAlpha = refer.bChanged_grayscaleToAlpha;
        bChanged_anisoLevel = refer.bChanged_anisoLevel;

        bChanged_mipmapEnabled = refer.bChanged_mipmapEnabled;
        bChanged_borderMipmap = refer.bChanged_borderMipmap;
        bChanged_generateMipsInLinearSpace = refer.bChanged_generateMipsInLinearSpace;
        bChanged_mipmapFilter = refer.bChanged_mipmapFilter;
        bChanged_fadeout = refer.bChanged_fadeout;
        bChanged_mipmapFadeDistance = refer.bChanged_mipmapFadeDistance;
        bChanged_Tex_Android_maxTextureSize = refer.bChanged_Tex_Android_maxTextureSize;
        bChanged_Tex_IOS_maxTextureSize = refer.bChanged_Tex_IOS_maxTextureSize;
        bChanged_Tex_Android_TextureImporterFormat = refer.bChanged_Tex_Android_TextureImporterFormat;
        bChanged_Tex_IOS_TextureImporterFormat = refer.bChanged_Tex_IOS_TextureImporterFormat;

        Mesh_Generate2uv = refer.Mesh_Generate2uv;
        Mesh_SetReadable = refer.Mesh_SetReadable;
        Mesh_SetOptimizeMesh = refer.Mesh_SetOptimizeMesh;
        Mesh_ImporterCompression = refer.Mesh_ImporterCompression;

        bChanged_Mesh_Generate2uv = refer.bChanged_Mesh_Generate2uv;
        bChanged_Mesh_SetReadable = refer.bChanged_Mesh_SetReadable;
        bChanged_Mesh_SetOptimizeMesh = refer.bChanged_Mesh_SetOptimizeMesh;
        bChanged_Mesh_ImporterCompression = refer.bChanged_Mesh_ImporterCompression;

        Mesh_SetAnimationType       = refer.Mesh_SetAnimationType;
        Mesh_SetGenerateAnimations  = refer.Mesh_SetGenerateAnimations;
        Mesh_SetModelImporterAnimationCompression = refer.Mesh_SetModelImporterAnimationCompression;
        Mesh_SetanimationPositionError = refer.Mesh_SetanimationPositionError;
        Mesh_SetanimationRotationError = refer.Mesh_SetanimationRotationError;
        Mesh_SetanimationScaleError = refer.Mesh_SetanimationScaleError;
        Mesh_SetModelImporterTangentSpaceMode = refer.Mesh_SetModelImporterTangentSpaceMode;

        bChanged_Mesh_SetAnimationType = refer.bChanged_Mesh_SetAnimationType;
        bChanged_Mesh_SetGenerateAnimations = refer.bChanged_Mesh_SetGenerateAnimations;
        bChanged_Mesh_SetanimationPositionError = refer.bChanged_Mesh_SetanimationPositionError;
        bChanged_Mesh_SetanimationRotationError = refer.bChanged_Mesh_SetanimationRotationError;
        bChanged_Mesh_SetanimationScaleError = refer.bChanged_Mesh_SetanimationScaleError;
        bChanged_Mesh_SetModelImporterAnimationCompression = refer.bChanged_Mesh_SetModelImporterAnimationCompression;
        bChanged_Mesh_SetModelImporterTangentSpaceMode = refer.bChanged_Mesh_SetModelImporterTangentSpaceMode;

        Audio_SetAudioCompressionFormat = refer.Audio_SetAudioCompressionFormat;
        Audio_SetAudioImporterLoadType = refer.Audio_SetAudioImporterLoadType;
        Audio_SetAudioSampleRateSetting = refer.Audio_SetAudioSampleRateSetting;
        
        bChanged_Audio_SetAudioCompressionFormat = refer.bChanged_Audio_SetAudioCompressionFormat;
        bChanged_Audio_SetAudioImporterLoadType = refer.bChanged_Audio_SetAudioImporterLoadType;
        bChanged_Audio_SetAudioSampleRateSetting = refer.bChanged_Audio_SetAudioSampleRateSetting;
    }
    public bool IsEqual(TMImporterSetting refValue)
    {
        if (bEnableImportSetting != refValue.bEnableImportSetting)
        {
            return false;
        }

        if (bChanged_ImporterType != refValue.bChanged_ImporterType)
        {
            return false;
        }

        if ( bChanged_ImporterType  && Tex_ImporterType != refValue.Tex_ImporterType)
        {
            return false;
        }

        if (bChanged_SpriteImport != refValue.bChanged_SpriteImport)
        {
            return false;
        }

        if (bChanged_SpriteImport && Tex_SpriteImport != refValue.Tex_SpriteImport)
        {
            return false;
        }

        if (bChanged_SetReadable != refValue.bChanged_SetReadable)
        {
            return false;
        }
        if (bChanged_SetReadable && Tex_SetReadable != refValue.Tex_SetReadable)
        {
            return false;
        }

        if (bChanged_generateCubemap != refValue.bChanged_generateCubemap)
        {
            return false;
        }
        if (bChanged_generateCubemap && Tex_generateCubemap != refValue.Tex_generateCubemap)
        {
            return false;
        }

        if (bChanged_filterMode != refValue.bChanged_filterMode)
        {
            return false;
        }
        if (bChanged_filterMode && Tex_filterMode != refValue.Tex_filterMode)
        {
            return false;
        }

        if (bChanged_wrapMode != refValue.bChanged_wrapMode)
        {
            return false;
        }
        if (bChanged_wrapMode && Tex_wrapMode != refValue.Tex_wrapMode)
        {
            return false;
        }

        if (bChanged_npotScale != refValue.bChanged_npotScale)
        {
            return false;
        }
        if (bChanged_npotScale && Tex_npotScale != refValue.Tex_npotScale)
        {
            return false;
        }

        if (bChanged_alphaIsTransparency != refValue.bChanged_alphaIsTransparency)
        {
            return false;
        }
        if (bChanged_alphaIsTransparency && Tex_alphaIsTransparency != refValue.Tex_alphaIsTransparency)
        {
            return false;
        }

        if (bChanged_grayscaleToAlpha != refValue.bChanged_grayscaleToAlpha)
        {
            return false;
        }
        if (bChanged_grayscaleToAlpha && Tex_grayscaleToAlpha != refValue.Tex_grayscaleToAlpha)
        {
            return false;
        }

        if (bChanged_anisoLevel != refValue.bChanged_anisoLevel)
        {
            return false;
        }
        if (bChanged_anisoLevel && Tex_anisoLevel != refValue.Tex_anisoLevel)
        {
            return false;
        }

        if (bChanged_mipmapEnabled != refValue.bChanged_mipmapEnabled)
        {
            return false;
        }
        if (bChanged_mipmapEnabled && Tex_mipmapEnabled != refValue.Tex_mipmapEnabled)
        {
            return false;
        }

        if (bChanged_borderMipmap != refValue.bChanged_borderMipmap)
        {
            return false;
        }
        if (bChanged_borderMipmap && Tex_borderMipmap != refValue.Tex_borderMipmap)
        {
            return false;
        }

        if (bChanged_generateMipsInLinearSpace != refValue.bChanged_generateMipsInLinearSpace)
        {
            return false;
        }
        if (bChanged_generateMipsInLinearSpace && Tex_generateMipsInLinearSpace != refValue.Tex_generateMipsInLinearSpace)
        {
            return false;
        }

        if (bChanged_mipmapFilter != refValue.bChanged_mipmapFilter)
        {
            return false;
        }
        if (bChanged_mipmapFilter && Tex_mipmapFilter != refValue.Tex_mipmapFilter)
        {
            return false;
        }

        if (bChanged_fadeout != refValue.bChanged_fadeout)
        {
            return false;
        }
        if (bChanged_fadeout && Tex_fadeout != refValue.Tex_fadeout)
        {
            return false;
        }

        if (bChanged_mipmapFadeDistance != refValue.bChanged_mipmapFadeDistance)
        {
            return false;
        }
        if (bChanged_mipmapFadeDistance && Tex_mipmapFadeDistanceEnd != refValue.Tex_mipmapFadeDistanceEnd)
        {
            return false;
        }
        if (bChanged_mipmapFadeDistance && Tex_mipmapFadeDistanceStart != refValue.Tex_mipmapFadeDistanceStart)
        {
            return false;
        }

        if (bChanged_Tex_Android_maxTextureSize && Tex_Android_maxTextureSize != refValue.Tex_Android_maxTextureSize)
        {
            return false;
        }

        if (bChanged_Tex_IOS_maxTextureSize && Tex_IOS_maxTextureSize != refValue.Tex_IOS_maxTextureSize)
        {
            return false;
        }

        if (bChanged_Tex_Android_TextureImporterFormat && Tex_Android_TextureImporterFormat != refValue.Tex_Android_TextureImporterFormat)
        {
            return false;
        }

        if (bChanged_Tex_IOS_TextureImporterFormat && Tex_IOS_TextureImporterFormat != refValue.Tex_IOS_TextureImporterFormat)
        {
            return false;
        }


        if (bChanged_Mesh_Generate2uv != refValue.bChanged_Mesh_Generate2uv)
        {
            return false;
        }
        if (bChanged_Mesh_Generate2uv && Mesh_Generate2uv != refValue.Mesh_Generate2uv)
        {
            return false;
        }

        if (bChanged_Mesh_ImporterCompression != refValue.bChanged_Mesh_ImporterCompression)
        {
            return false;
        }
        if (bChanged_Mesh_ImporterCompression && Mesh_ImporterCompression != refValue.Mesh_ImporterCompression)
        {
            return false;
        }

        if (bChanged_Mesh_SetReadable != refValue.bChanged_Mesh_SetReadable)
        {
            return false;
        }
        if (bChanged_Mesh_SetReadable && Mesh_SetReadable != refValue.Mesh_SetReadable)
        {
            return false;
        }

        if (bChanged_Mesh_SetOptimizeMesh != refValue.bChanged_Mesh_SetOptimizeMesh)
        {
            return false;
        }
        if (bChanged_Mesh_SetOptimizeMesh && Mesh_SetOptimizeMesh != refValue.Mesh_SetOptimizeMesh)
        {
            return false;
        }

        if (bChanged_Mesh_SetAnimationType && Mesh_SetAnimationType != refValue.Mesh_SetAnimationType)
        {
            return false;
        }

        if (bChanged_Mesh_SetGenerateAnimations && Mesh_SetGenerateAnimations != refValue.Mesh_SetGenerateAnimations)
        {
            return false;
        }


        if (bChanged_Mesh_SetModelImporterAnimationCompression && Mesh_SetModelImporterAnimationCompression != refValue.Mesh_SetModelImporterAnimationCompression)
        {
            return false;
        }
        if (bChanged_Mesh_SetanimationPositionError && Mesh_SetanimationPositionError != refValue.Mesh_SetanimationPositionError)
        {
            return false;
        }
        if (bChanged_Mesh_SetanimationRotationError && Mesh_SetanimationRotationError != refValue.Mesh_SetanimationRotationError)
        {
            return false;
        }
        if (bChanged_Mesh_SetanimationScaleError && Mesh_SetanimationScaleError != refValue.Mesh_SetanimationScaleError)
        {
            return false;
        }
        if (bChanged_Mesh_SetModelImporterTangentSpaceMode && Mesh_SetModelImporterTangentSpaceMode != refValue.Mesh_SetModelImporterTangentSpaceMode)
        {
            return false;
        }

        if (bChanged_Audio_SetAudioCompressionFormat && Audio_SetAudioCompressionFormat != refValue.Audio_SetAudioCompressionFormat)
        {
            return false;
        }
        if (bChanged_Audio_SetAudioImporterLoadType && Audio_SetAudioImporterLoadType != refValue.Audio_SetAudioImporterLoadType)
        {
            return false;
        }

        if (bChanged_Audio_SetAudioSampleRateSetting && Audio_SetAudioSampleRateSetting != refValue.Audio_SetAudioSampleRateSetting)
        {
            return false;
        }

        return true;
    }


    public void OnTextureGUI()
    {
        MyGUIUtility.EnumPopup(ref bChanged_ImporterType, "Texture Type", ref Tex_ImporterType);
        MyGUIUtility.EnumPopup(ref bChanged_npotScale, "Non Power of 2", ref Tex_npotScale);
        MyGUIUtility.EnumPopup(ref bChanged_generateCubemap, "Generate Cubemap", ref Tex_generateCubemap);
        MyGUIUtility.Toggle(ref bChanged_SetReadable, "Read/Write Enabled", ref Tex_SetReadable);
        MyGUIUtility.EnumPopup(ref bChanged_SpriteImport, "Sprite Mode", ref Tex_SpriteImport);
        //MyGUIUtility.Toggle(ref bChanged_alphaIsTransparency, "alphaIsTransparency", ref Tex_alphaIsTransparency);
        //MyGUIUtility.Toggle(ref bChanged_grayscaleToAlpha, "grayscaleToAlpha", ref Tex_grayscaleToAlpha);
        MyGUIUtility.Toggle(ref bChanged_mipmapEnabled, "Generate Mip Maps", ref Tex_mipmapEnabled);
        if (Tex_mipmapEnabled)
        {
            MyGUIUtility.Toggle(ref bChanged_generateMipsInLinearSpace, "    In Linear Space", ref Tex_generateMipsInLinearSpace);
            MyGUIUtility.Toggle(ref bChanged_borderMipmap, "    Borders Mip Maps", ref Tex_borderMipmap);
            MyGUIUtility.EnumPopup(ref bChanged_mipmapFilter, "    Mip Map Filtering", ref Tex_mipmapFilter);
            MyGUIUtility.Toggle(ref bChanged_fadeout, "    Fadeout Mip Maps", ref Tex_fadeout);
            if (Tex_fadeout)
            {
                MyGUIUtility.MinMaxSlider(ref bChanged_mipmapFadeDistance, "       Fade Range", ref Tex_mipmapFadeDistanceStart, ref Tex_mipmapFadeDistanceEnd);
            }
        }
        MyGUIUtility.EnumPopup(ref bChanged_wrapMode, "Wrap Mode", ref Tex_wrapMode);
        MyGUIUtility.EnumPopup(ref bChanged_filterMode, "Filter Mode", ref Tex_filterMode);
        if (Tex_filterMode == FilterMode.Bilinear ||
            Tex_filterMode == FilterMode.Trilinear
            )
        {
            MyGUIUtility.IntSlider(ref bChanged_anisoLevel, "Aniso Level", ref Tex_anisoLevel, 0, 9);
        }

        MyGUIUtility.EnumPopup(ref bChanged_Tex_Android_maxTextureSize, "Android Max Texture", ref Tex_Android_maxTextureSize);
        MyGUIUtility.EnumPopup(ref bChanged_Tex_IOS_maxTextureSize, "IOS Max Texture", ref Tex_IOS_maxTextureSize);
        MyGUIUtility.EnumPopup(ref bChanged_Tex_Android_TextureImporterFormat, "Android Texture Format", ref Tex_Android_TextureImporterFormat);
        MyGUIUtility.EnumPopup(ref bChanged_Tex_IOS_TextureImporterFormat, "Ios Texture Format", ref Tex_IOS_TextureImporterFormat);

    }

    public void OnAudioGUI()
    {
        MyGUIUtility.EnumPopup(ref bChanged_Audio_SetAudioCompressionFormat, "Importer Format", ref Audio_SetAudioCompressionFormat);
        MyGUIUtility.EnumPopup(ref bChanged_Audio_SetAudioImporterLoadType, "Importer Load Type", ref Audio_SetAudioImporterLoadType);
        MyGUIUtility.EnumPopup(ref bChanged_Audio_SetAudioSampleRateSetting, "Importer Audio SampleRate", ref Audio_SetAudioSampleRateSetting);
    }

    public void OnMeshGUI()
    {
        MyGUIUtility.EnumPopup(ref bChanged_Mesh_ImporterCompression, "Mesh Compression", ref Mesh_ImporterCompression);
        MyGUIUtility.Toggle(ref bChanged_Mesh_Generate2uv, "Generate 2th UV", ref Mesh_Generate2uv);
        MyGUIUtility.Toggle(ref bChanged_Mesh_SetReadable, "Read/Write Enabled", ref Mesh_SetReadable);
        MyGUIUtility.Toggle(ref bChanged_Mesh_SetOptimizeMesh, "Optimize Mesh", ref Mesh_SetOptimizeMesh);

        MyGUIUtility.EnumPopup(ref bChanged_Mesh_SetAnimationType, "AnimationType", ref Mesh_SetAnimationType);
        MyGUIUtility.EnumPopup(ref bChanged_Mesh_SetGenerateAnimations, "GenerateAnimations", ref Mesh_SetGenerateAnimations);
        MyGUIUtility.EnumPopup(ref bChanged_Mesh_SetModelImporterAnimationCompression, "Animation Compression", ref Mesh_SetModelImporterAnimationCompression);
        MyGUIUtility.EnumPopup(ref bChanged_Mesh_SetanimationPositionError, "animation Position Error", ref Mesh_SetanimationPositionError);
        MyGUIUtility.EnumPopup(ref bChanged_Mesh_SetanimationRotationError, "animation Rotation Error", ref Mesh_SetanimationRotationError);
        MyGUIUtility.EnumPopup(ref bChanged_Mesh_SetanimationScaleError, "animation Scale Error", ref Mesh_SetanimationScaleError);
        MyGUIUtility.EnumPopup(ref bChanged_Mesh_SetModelImporterTangentSpaceMode, "Normal Import Setting", ref Mesh_SetModelImporterTangentSpaceMode);
    }

    public void HandleTexture(TextureImporter ti)
    {
        if (bEnableImportSetting == false)
        {
            return;
        }

        if (bChanged_ImporterType)
            ti.textureType      = Tex_ImporterType;
        if (bChanged_SpriteImport)
            ti.spriteImportMode = Tex_SpriteImport;
        if (bChanged_SetReadable)
            ti.isReadable       = Tex_SetReadable;
        if (bChanged_generateCubemap)
            ti.generateCubemap  = Tex_generateCubemap;
        if (bChanged_filterMode)
            ti.filterMode       = Tex_filterMode;
        if (bChanged_wrapMode)
            ti.wrapMode         = Tex_wrapMode;
        if (bChanged_npotScale)
            ti.npotScale        = Tex_npotScale;
        if (bChanged_alphaIsTransparency)
            ti.alphaIsTransparency = Tex_alphaIsTransparency;
        if (bChanged_grayscaleToAlpha)
            ti.grayscaleToAlpha = Tex_grayscaleToAlpha;
        if (bChanged_anisoLevel)
            ti.anisoLevel       = Tex_anisoLevel;
        if (bChanged_mipmapEnabled)
            ti.mipmapEnabled    = Tex_mipmapEnabled;
        if (bChanged_borderMipmap)
            ti.borderMipmap     = Tex_borderMipmap;
        if (bChanged_generateMipsInLinearSpace)
            ti.generateMipsInLinearSpace = Tex_generateMipsInLinearSpace;
        if (bChanged_mipmapFilter)
            ti.mipmapFilter     = Tex_mipmapFilter;
        if (bChanged_fadeout)
            ti.fadeout          = Tex_fadeout;
        if (bChanged_mipmapFadeDistance)
        {
            ti.mipmapFadeDistanceEnd = Tex_mipmapFadeDistanceEnd;
            ti.mipmapFadeDistanceStart = Tex_mipmapFadeDistanceStart;
        }

        if (bChanged_Tex_Android_maxTextureSize)
        {
            int curMaxTextureSize = 0;
            TextureImporterFormat curTi = new TextureImporterFormat();;
            ti.GetPlatformTextureSettings("Android", out curMaxTextureSize, out curTi);
            ti.SetPlatformTextureSettings("Android", Tex_Android_maxTextureSize, curTi);
        }

        if (bChanged_Tex_IOS_maxTextureSize)
        {
            int curMaxTextureSize = 0;
            TextureImporterFormat curTi = new TextureImporterFormat(); ;
            ti.GetPlatformTextureSettings("iPhone", out curMaxTextureSize, out curTi);
            ti.SetPlatformTextureSettings("iPhone", Tex_IOS_maxTextureSize, curTi);
        }

        if (bChanged_Tex_Android_TextureImporterFormat)
        {
            int curMaxTextureSize = 0;
            TextureImporterFormat curTi = new TextureImporterFormat(); ;
            ti.GetPlatformTextureSettings("Android", out curMaxTextureSize, out curTi);
            ti.SetPlatformTextureSettings("Android", curMaxTextureSize, Tex_Android_TextureImporterFormat);
        }

        if (bChanged_Tex_IOS_TextureImporterFormat)
        {
            int curMaxTextureSize = 0;
            TextureImporterFormat curTi = new TextureImporterFormat(); ;
            ti.GetPlatformTextureSettings("iPhone", out curMaxTextureSize, out curTi);
            ti.SetPlatformTextureSettings("iPhone", curMaxTextureSize, Tex_IOS_TextureImporterFormat);
        }

    }

    public void HandleAudio(AudioImporter ai)
    {
        if (bEnableImportSetting == false)
        {
            return;
        }

        AudioImporterSampleSettings aiss = new AudioImporterSampleSettings();

        if (bChanged_Audio_SetAudioCompressionFormat)
        {
            aiss.compressionFormat = Audio_SetAudioCompressionFormat;
        }
        if (bChanged_Audio_SetAudioImporterLoadType)
        {
            aiss.loadType = Audio_SetAudioImporterLoadType;
        }
        if (bChanged_Audio_SetAudioSampleRateSetting)
        {
            aiss.sampleRateSetting = Audio_SetAudioSampleRateSetting;
        }
        ai.defaultSampleSettings = aiss;
    }

    public void HandleMesh(ModelImporter mi)
    {
        if (bEnableImportSetting == false)
        {
            return;
        }

        if (bChanged_Mesh_Generate2uv)
        {
            mi.generateSecondaryUV = Mesh_Generate2uv;
        }

        if (bChanged_Mesh_SetReadable)
        {
            mi.isReadable = Mesh_SetReadable;
        }

        if (bChanged_Mesh_SetOptimizeMesh)
        {
            mi.optimizeMesh = Mesh_SetOptimizeMesh;
        }

        if (bChanged_Mesh_ImporterCompression)
        {
            mi.meshCompression = Mesh_ImporterCompression;
        }

        if (bChanged_Mesh_SetAnimationType)
        {
            mi.animationType = Mesh_SetAnimationType;
        }

        if (bChanged_Mesh_SetGenerateAnimations)
        {
            mi.generateAnimations = Mesh_SetGenerateAnimations;
        }

        if (bChanged_Mesh_SetModelImporterAnimationCompression)
        {
            mi.animationCompression = Mesh_SetModelImporterAnimationCompression;
        }

        if (bChanged_Mesh_SetanimationPositionError)
        {
            mi.animationPositionError = (float)Mesh_SetanimationPositionError;
        }
        if (bChanged_Mesh_SetanimationRotationError)
        {
            mi.animationRotationError = (float)Mesh_SetanimationRotationError;
        }
        if (bChanged_Mesh_SetanimationScaleError)
        {
            mi.animationScaleError = (float)Mesh_SetanimationScaleError;
        }
        if (bChanged_Mesh_SetModelImporterTangentSpaceMode)
        {
            mi.normalImportMode = Mesh_SetModelImporterTangentSpaceMode;
        }

    }
}
