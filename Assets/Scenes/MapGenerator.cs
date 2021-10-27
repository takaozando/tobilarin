using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public Material materialMap;

    public Vector3 testePosicao;   
    public int testeTamanho;
    public int testeAltura;
    public int testeLargura;


    private void OnPostRender()
    {
        GL.PushMatrix();
        materialMap.SetPass(0);

        GeraQuadrado(12,new Vector3(3,-5,0));
        GeraQuadrado(12, new Vector3(-15, -5, 0));

        GeraRetangulo(testeAltura, testeLargura, testePosicao);


        GL.PopMatrix();
    }

  

    public void GeraQuadrado(float lado, Vector3 posicao)
    {
        
        GL.Color(Color.cyan);
        GL.Begin(GL.QUADS);
        
        GL.Vertex3(posicao.x, posicao.y, posicao.z);
        GL.Vertex3(posicao.x, posicao.y+lado, posicao.z);
        GL.Vertex3(posicao.x+lado, posicao.y+lado, posicao.z);
        GL.Vertex3(posicao.x+lado, posicao.y, posicao.z);

        GL.End();
        GL.Color(Color.clear);
    }

    public void GeraRetangulo(float altura,float largura, Vector3 posicao)
    {
        
        
        GL.Begin(GL.QUADS);
        GL.Color(Color.green);

        GL.Vertex3(posicao.x, posicao.y, posicao.z);
        GL.Vertex3(posicao.x, posicao.y + altura, posicao.z);
        GL.Vertex3(posicao.x + largura, posicao.y + altura, posicao.z);
        GL.Vertex3(posicao.x + largura, posicao.y, posicao.z);

        GL.End();
        GL.Color(Color.clear);
    }

}
