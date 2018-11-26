using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createCube : MonoBehaviour {

public GameObject Cube;
public Transform newPosition;
Vector3 pos = new Vector3(1, 1, 1);
private int count = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)&& count == 0) {
        Instantiate(Cube, pos, Quaternion.identity);
	   	Debug.Log("Test");
		   count++;
     }
	}
}
