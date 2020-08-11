Shader "Custom/Circle"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
    }
    SubShader
    {
        Tags {  "Queue" = "Transparent"}
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard alpha:fade
        //#pragma surface surf Standard fullforwardshadows
        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
            float3 worldPos;
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
            c = fixed4(0.1f, 0.1f, 0.1f, 1);
            o.Albedo = c.rgb;
            // Metallic and smoothness come from slider variables
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            //o.Alpha = c.a;

            float dist = distance(fixed3(0,0,0), IN.worldPos);
            float radius = 1;
            if (dist < radius ){
                o.Albedo = fixed4(200/255.0f, 200/255.0f, 200/255.0f, 1);
                o.Alpha = 0.8f;
            }else{
                o.Albedo = fixed4(0, 0, 0, 0);
                o.Alpha = 0.0f;
            }
            if(IN.worldPos.x > 0 && IN.worldPos.z < 5){
                o.Albedo = fixed4(1.0f, 0.0f, 0.0f, 1);
            }
        }
        ENDCG
    }
    FallBack "Diffuse"
}
