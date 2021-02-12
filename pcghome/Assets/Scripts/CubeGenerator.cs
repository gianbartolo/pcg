﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
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
        m_Material.color = Color.green;
    }

    void CreateShape(){

        vertices = new Vector3[]
        {
            new Vector3 (0, 0, 0),
	new Vector3 (1, 0, 0),
	new Vector3 (1, 1, 0),
	new Vector3 (0, 1, 0),
	new Vector3 (0, 1, 1),
	new Vector3 (1, 1, 1),
	new Vector3 (1, 0, 1),
	new Vector3 (0, 0, 1),
        };

        triangles = new int[]
        {
            0, 2, 1, 
        	0, 3, 2,
	        2, 3, 4, 
	        2, 4, 5,
	        1, 2, 5, 
	        1, 5, 6,
	        0, 7, 4, 
	        0, 4, 3,
	        5, 4, 7,
	        5, 7, 6,
	        0, 6, 7, 
	        0, 1, 6
        };

    }

    void UpdateShape(){

        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
}
