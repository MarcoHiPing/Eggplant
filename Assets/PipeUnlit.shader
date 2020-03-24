Shader "Unlit/PipeUnlit"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
		_DefaultColor("DefaultColor", Color) = (1,1,1,1)
		_FillSlider("FillSlider",Range(0,1)) = 1.0
		_FillColor("FillColor", Color) = (1,1,1,1)
    }
    SubShader
    {
        Tags { "Queue" = "Transparent" "RenderType"="Transparent" }
        LOD 100
	
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
			fixed4 _FillColor;
			fixed4 _DefaultColor;
			float _FillSlider;
            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

			fixed4 frag(v2f i) : SV_Target
			{
				// sample the texture
				fixed4 col;
				if (i.uv.y > _FillSlider)
				col = tex2D(_MainTex, i.uv)* _DefaultColor;
				else
				col = _FillColor;
                // apply fog
                UNITY_APPLY_FOG(i.fogCoord, col);
                return col;
            }
            ENDCG
        }
    }
}
