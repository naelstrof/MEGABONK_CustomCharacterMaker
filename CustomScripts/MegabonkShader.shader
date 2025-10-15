Shader "Custom/MegabonkShader"
{
    Properties
    {
         _Surface ("_Surface", Float) = 0
         _Blend ("_Blend", Float) = 0
         _AlphaClipping ("_AlphaClipping", Float) = 0
         _RenderFace ("_RenderFace", Float) = 2
         _AlbedoColor ("_AlbedoColor", Color) = (1,1,1,1)
         _AlphaCutoff ("_AlphaCutoff", Range(0,1)) = 0.5
         _AlbedoMap ("_AlbedoMap", 2D) = "white" {}
         _AlbedoMapIntensity ("_AlbedoMapIntensity", Range(0,1)) = 1
         _SpecularColor ("_SpecularColor", Color) = (1,1,1,1)
         _SpecularMap ("_SpecularMap", 2D) = "white" {}
         _Smoothness ("_Smoothness", Range(0,1)) = 0.5
         _NormalMapIntensity ("_NormalMapIntensity", Float) = 1
         _NormalMap ("_NormalMap", 2D) = "bump" {}
         _EmissionColor ("_EmissionColor", Color) = (0,0,0,1)
         _EmissionMap ("_EmissionMap", 2D) = "black" {}
         _Light ("_Light", Float) = 1
         _DiffuseRamp ("_DiffuseRamp", 2D) = "grey" {}
         _DiffuseSmoothness ("_DiffuseSmoothness", Range(0,1)) = 0
         _DiffuseThresholdOffset ("_DiffuseThresholdOffset", Range(0,1)) = 0.25
         _SpecularRamp ("_SpecularRamp", 2D) = "grey" {}
         _SpecularSmoothness ("_SpecularSmoothness", Range(0,1)) = 0
         _SpecularThresholdOffset ("_SpecularThresholdOffset", Range(0,1)) = 0.25
         _RimRamp ("_RimRamp", 2D) = "grey" {}
         _RimSmoothness ("_RimSmoothness", Range(0,1)) = 0.5
         _RimThresholdOffset ("_RimThresholdOffset", Range(0,1)) = 0.25
         _LightBands ("_LightBands", Range(2,12)) = 4
         _LightBandsScale ("_LightBandsScale", Range(0,1)) = 0.5
         _LightThreshold ("_LightThreshold", Range(0,1)) = 0.5
         _ThresholdMap ("_ThresholdMap", 2D) = "gray" {}
         _ThresholdMapScale ("_ThresholdMapScale", Float) = 1
         _GoochRampIntensity ("_GoochRampIntensity", Range(0,1)) = 0.5
         _GoochRamp ("_GoochRamp", 2D) = "white" {}
         _GoochBrightColor ("_GoochBrightColor", Color) = (1,1,1,1)
         _GoochDarkColor ("_GoochDarkColor", Color) = (0,0,0,1)
         _Contrast ("_Contrast", Float) = 1
         _Saturation ("_Saturation", Float) = 1
         _Brightness ("_Brightness", Float) = 1
         _Iridescence ("_Iridescence", Float) = 0
         _IridescenceRamp ("_IridescenceRamp", 2D) = "white" {}
         _IridescenceSize ("_IridescenceSize", Range(0,5)) = 1
         _IridescenceColor ("_IridescenceColor", Color) = (1,1,1,0.5)
         _IridescenceSmoothness ("_IridescenceSmoothness", Range(0,1)) = 0.5
         _IridescenceThresholdOffset ("_IridescenceThresholdOffset", Range(0,1)) = 0
         _Rim ("_Rim", Float) = 0
         _RimSize ("_RimSize", Range(0,5)) = 1
         _RimColor ("_RimColor", Color) = (1,1,1,1)
         _RimBrightColor ("_RimBrightColor", Color) = (1,1,1,1)
         _RimDarkColor ("_RimDarkColor", Color) = (0,0,0,1)
         _ColorGrading ("_ColorGrading", Float) = 0
         _VertexAnimationStutter ("_VertexAnimationStutter", Float) = 0
         _VertexAnimation ("_VertexAnimation", Float) = 0
         _VertexAnimationIntensity ("_VertexAnimationIntensity", Range(0,1)) = 0.05
         _VertexAnimationMap ("_VertexAnimationMap", 2D) = "white" {}
         _VertexAnimationFrequency ("_VertexAnimationFrequency", Vector) = (2.5,2.5,2.5,1)
         _Dissolve ("_Dissolve", Float) = 0
         _DissolveMapScale ("_DissolveMapScale", Float) = 1
         _DissolveMap ("_DissolveMap", 2D) = "white" {}
         _DissolveAmount ("_DissolveAmount", Range(0,1)) = 0.5
         _DissolveBorderSize ("_DissolveBorderSize", Range(0,1)) = 0.25
         _DissolveBorderRamp ("_DissolveBorderRamp", 2D) = "white" {}
         _DissolveBorderColor ("_DissolveBorderColor", Color) = (1,1,1,1)
         _Artistic ("_Artistic", Float) = 0
         _ArtisticProjection ("_ArtisticProjection", Float) = 0
         _ArtisticFrequency ("_ArtisticFrequency", Range(1,10)) = 1
         _DrawnMapScale ("_DrawnMapScale", Float) = 1
         _DrawnMap ("_DrawnMap", 2D) = "white" {}
         _DrawnClampMin ("_DrawnClampMin", Range(0,1)) = 0
         _DrawnClampMax ("_DrawnClampMax", Range(0,1)) = 1
         _HatchingMapScale ("_HatchingMapScale", Float) = 1
         _HatchingBrightMap ("_HatchingBrightMap", 2D) = "white" {}
         _HatchingDarkMap ("_HatchingDarkMap", 2D) = "Black" {}
         _SketchMapScale ("_SketchMapScale", Float) = 1
         _SketchMap ("_SketchMap", 2D) = "black" {}
         _BlendSrc ("_BlendSrc", Float) = 1
         _BlendDst ("_BlendDst", Float) = 0
         _ZWrite ("_ZWrite", Float) = 1
         _ZTest ("_ZTest", Float) = 4
         _WrappedLighting ("_WrappedLighting", Float) = 1
         _IndirectFade ("_IndirectFade", Range(0,1)) = 1
         _ReceiveShadows ("_ReceiveShadows", Float) = 1
         _Specular ("_Specular", Float) = 0
         _SpecularIntensity ("_SpecularIntensity", Float) = 1
         _EnvironmentReflections ("_EnvironmentReflections", Float) = 1
         _RenderPriority ("_RenderPriority", Range(-50,50)) = 0
         _Stencil ("_Stencil", Float) = 1
         _StencilRef ("_StencilRef", Range(0,255)) = 0
         _StencilReadMask ("_StencilReadMask", Range(0,255)) = 255
         _StencilWriteMask ("_StencilWriteMask", Range(0,255)) = 255
         _StencilComp ("_StencilComp", Float) = 8
         _StencilPass ("_StencilPass", Float) = 0
         _StencilFail ("_StencilFail", Float) = 0
         _StencilZFail ("_StencilZFail", Float) = 0
         _Outline ("_Outline", Float) = 3
         _OutlineData ("_OutlineData", Float) = 0
         _OutlineFadeMin ("_OutlineFadeMin", Float) = 0.25
         _OutlineFadeMax ("_OutlineFadeMax", Float) = 2
         _OutlineMap ("_OutlineMap", 2D) = "white" {}
         _OutlineSize ("_OutlineSize", Float) = 5
         _OutlineColor ("_OutlineColor", Color) = (0,0,0,1)
         _OutlineNoise ("_OutlineNoise", Range(-1,1)) = 0
         _Initialized ("_Initialized", Float) = 0
         _OptionsTab ("_OptionsTab", Float) = 1
         _InputTab ("_InputTab", Float) = 1
         _StylizeTab ("_StylizeTab", Float) = 0
         _AdvancedTab ("_AdvancedTab", Float) = 0
         _OutlineTab ("_OutlineTab", Float) = 0
         _Cutoff ("_Cutoff", Range(0,1)) = 0.5
         _MainTex ("_MainTex", 2D) = "white" {}
         _Color ("_Color", Color) = (1,1,1,1)
         
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        half _Glossiness;
        half _Metallic;
        fixed4 _Color;

        // Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
        // See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
        // #pragma instancing_options assumeuniformscaling
        UNITY_INSTANCING_BUFFER_START(Props)
            // put more per-instance properties here
        UNITY_INSTANCING_BUFFER_END(Props)

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            // Albedo comes from a texture tinted by color
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
            o.Albedo = c.rgb;
            // Metallic and smoothness come from slider variables
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
