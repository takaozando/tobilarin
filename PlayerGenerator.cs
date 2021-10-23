using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public Material material;
    
    public Vector2 sb;
    public Vector2 playerPosition;
    public int playerSize = 1;

    private void Start()
    {
        sb = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    public void Update()
    {
        GetPlayerPoisition();
    }


    private void OnPostRender()
    {
        GL.PushMatrix();
        material.SetPass(0);

        GeraCirculo(playerSize,new Vector3(playerPosition.x, playerPosition.y));
        GL.PopMatrix();
    }

    private void GetPlayerPoisition()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerPosition.y += 1;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerPosition.y -= 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerPosition.x -= 1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerPosition.x += 1;
        }
    }

    public void GeraCirculo(float tamanho, Vector3 center)
    {

        GL.Begin(GL.LINES);

        for (var t = 0.0f; t < (2 * Mathf.PI); t += 0.01f)
        {
            Vector3 ci = (new Vector3(Mathf.Cos(t) * tamanho + center.x, Mathf.Sin(t) * tamanho + center.y, center.z));
            GL.Vertex3(ci.x, ci.y, ci.z);
        }
        GL.End();

    }

}
