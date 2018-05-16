using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshBuilder : MonoBehaviour {
	MeshFilter mf;
	Mesh mesh;
	Vector3[] vertices;
	int[] triangles;
	Vector2[] uvs;
	// Use this for initialization
	void Start () {
		mf = GetComponent<MeshFilter> ();
		mf = MeshFilter.mesh;

		vertices = new Vector3[] {
			new Vector3 (-1, 1, 1),//left top
			new Vector3 (1, 1, 1), //right top
			new Vector3 (-1, -1, 1),//left bottom
			new Vector3 (1, -1, 1)//right bottom

		};
			//Triangles;
		triangles = new int[] {
			0, 1, 2,
			2, 1, 3
		};

		uvs = new Vector2[]{
			
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
