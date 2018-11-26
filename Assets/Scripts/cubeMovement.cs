using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement : MonoBehaviour {
private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal") * 5;
		float v = Input.GetAxis("Vertical") * 5;

		Vector3 vel = rb.velocity;
		vel.x = h;
		vel.z = v;
		rb.velocity = vel;
	}
	
}
