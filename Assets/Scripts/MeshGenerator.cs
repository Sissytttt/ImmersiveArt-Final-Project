using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshFilter))]
public class MeshGenerator : MonoBehaviour
{
    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;

    public int xSize;
    public int zSize;
    
    public float noiseXattr = 0;
    public float noiseAdd;
    
    
    public float variance;

    public float varianceChangeAdd;

    public float varianceMax;
    
    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        CreateShape();
        // varianceChange = variance;
        //CreateShape();
        //UpdateMesh();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateMesh();
    }


    
    void CreateShape()
    {
        vertices = new Vector3[(xSize + 1) * (zSize + 1)];


        // Debug.Log();
        for (int x = 0, i = 0; x < xSize + 1; x++)
        {
            for (int z = 0; z < zSize + 1; z++)
            {
                float y;

                // if (x < 55 && x > 40 && z < 55 && z > 40)
                // {
                //     y = Mathf.PerlinNoise((x) * .3f, z * .3f) * varianceChange;
                // }
                
                // else
                // {
                y = Mathf.PerlinNoise((x + noiseXattr) * .3f, z * .3f) * variance;
                // }
                vertices[i] = new Vector3(x, y, z);
                i++;
            }
        }

        triangles = new int[xSize * zSize * 6];
        int vert = 0;
        int tris = 0;
        for (int z = 0; z < zSize; z++)
        {
            for (int x = 0; x < xSize; x++)
            {
                triangles[tris + 0] = vert + 0;
                triangles[tris + 1] = vert + 1;
                triangles[tris + 2] = vert + xSize + 1;
                triangles[tris + 3] = vert + 1;
                triangles[tris + 4] = vert + xSize + 2;
                triangles[tris + 5] = vert + xSize + 1;
                vert++;
                tris += 6;
            }
            vert++;
        }
    }

    void UpdateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
        
        noiseXattr += noiseAdd;
        if (variance < varianceMax)
        {
            variance += varianceChangeAdd;
        }

        // for (int i = 0; i < vertices.Length; i++)
        // {
        //     vertices[i].y+=;
        // }
        for (int x = 0, i = 0; x < xSize + 1; x++)
        {
            for (int z = 0; z < zSize + 1; z++)
            {
                var y = Mathf.PerlinNoise((x + noiseXattr) * .3f, z * .3f) * variance;
                vertices[i].y = y;
                i++;
            }
        }
    }

    // private void OnDrawGizmos()
    // {
    //     if (vertices == null)
    //         return;
    //     for (int i = 0; i < vertices.Length; i++)
    //     {
    //         Gizmos.DrawSphere(vertices[i], .1f) ;
    //     }
    // }

}
