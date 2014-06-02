// Unlit shader. Simplest possible textured shader.
// - no lighting
// - no lightmap support
// - no per-material color

Shader "Heathen/Glow/UnlitColorTransparent" {
Properties {
	_MainTex ("Base (RGB)", 2D) = "white" {}
	_Color ("Color", Color) = (1,1,1,1)
	_GlowColor ("Glow Color", Color) = (1,1,1,1)
	_Inner ("Inner Intensity", Range(0.1,10)) = 2.0
	_Outter ("Outter Intensity", Range(0.1,10)) = 2.0
	_GlowMap ("Glow (A)", 2D) = "white" {}
}

SubShader {
	Tags { "RenderType"="SelectiveGlow" "Queue" = "Transparent" }
	Blend SrcAlpha OneMinusSrcAlpha
	Cull Off
	LOD 100
	
	Pass {  
		ZWrite On
		ZTest On
		Cull Back
		CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata_t {
				float4 vertex : POSITION;
			};

			struct v2f {
				float4 vertex : SV_POSITION;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
			
			v2f vert (appdata_t v)
			{
				v2f o;
				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
				return o;
			}
			
			fixed4 _Color;			
			fixed4 frag (v2f i) : COLOR
			{
				return _Color;
			}
		ENDCG
	}
}

}
