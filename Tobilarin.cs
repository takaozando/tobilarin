using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tobilarin : MonoBehaviour
{
    public Material mat;
    //use this variable in unity, to choose the draw(1~14)
    public int choice = 0;
    public Vector2 sb;


    private void Start()
    {
        sb = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    private void OnPostRender()
    {
        GL.PushMatrix();
        mat.SetPass(0);
        GL.Begin(GL.LINES);
        GL.Color(Color.red);

        GL.Vertex(new Vector3(0, 0, 0));
        GL.Vertex(new Vector3(sb.x,sb.y, 0));



        GL.End();
        GL.PopMatrix();
    }
}