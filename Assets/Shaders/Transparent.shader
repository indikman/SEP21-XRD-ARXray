Shader "Custom/Transparent"
{
    
    SubShader
    {
        Tags { "Queue" = "Transparent+1" } // 3001 transparent queue

        Pass { Blend Zero One }
        
    }
}
