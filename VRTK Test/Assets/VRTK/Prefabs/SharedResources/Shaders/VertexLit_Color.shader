﻿// UNITY_SHADER_NO_UPGRADE
Shader "VRTK/VertexLit/TransparentColor"
{
	Properties
	{
		_Color("Main Color", Color) = (1,1,1,1)
		_MainTex("Base (RGB)", 2D) = "white" {}
	}

	Category
	{
		Blend SrcAlpha OneMinusSrcAlpha
		Tags{ Queue = Transparent }

		SubShader
		{
			Tags { "RenderType" = "Transparent" }
			LOD 200

			CGPROGRAM
			#pragma surface surf Lambert

			sampler2D _MainTex;
			fixed4 _Color;

			struct Input
			{
				float2 uv_MainTex;
			};

			void surf(Input IN, inout SurfaceOutput o)
			{
				fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
				o.Albedo = c.rgb;
				o.Alpha = c.a;
			}
			ENDCG
		}
	}
}