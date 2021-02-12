using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidGenerator : MonoBehaviour
{

    Mesh mesh;

    public Vector3[] vertices;
    public int[] triangles;
    Material m_Material;

    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        CreateShape();
        UpdateShape();
        m_Material = GetComponent<Renderer>().material;
        m_Material.color = Color.blue;
    }

    void CreateShape(){

        vertices = new Vector3[]
        {
            new Vector3(-1.0f, 0.0f, 0.0f),
            new Vector3(0.0f, 0.0f, -1.5f),
            new Vector3(1.0f, 0.0f, 0.0f),
            new Vector3(0.0f, 1.0f, -0.8f)

        };

        triangles = new int[]
        {
            0, 1, 2,
            0,3,1,
            1,3,2,
            2,3,0
        };

    }

    void UpdateShape(){

        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
}
