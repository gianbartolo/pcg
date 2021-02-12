using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGenerator : MonoBehaviour
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
        m_Material.color = Color.red;
    }

    void CreateShape(){

        vertices = new Vector3[]
        {

            new Vector3(0,0,0),
            new Vector3(0,0,1),
            new Vector3(1,0,0)
        };

        triangles = new int[]
        {

            0,1,2
        };

    }

    void UpdateShape(){

        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
}
