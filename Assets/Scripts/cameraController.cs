using UnityEngine;

public class cameraController : MonoBehaviour {
	public Transform player;

	public float smoothSpeed = 0.125f;
	public Vector3 offset ;

	public float speedH = 2.0f;
	public float speedV = 2.0f;

	private float yaw = 0.0f;
	private float pitch = 0.0f;
	//offset.z = -4;

	// Use this for initialization
	void Start () {
		offset = transform.position/2 ;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.position + offset;
		yaw+= speedH * Input.GetAxis("Mouse X");
		pitch -= speedV * Input.GetAxis("Mouse Y");
		transform.eulerAngles = new Vector3(pitch,yaw,0.0f);

	}
}
