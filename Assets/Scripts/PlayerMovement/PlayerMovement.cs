using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed = 100.0f;
	public float rotateSpeed = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("w")){
			transform.Translate((Vector3.forward)*moveSpeed*Time.deltaTime);
			Debug.Log("Pressing W key");
		}
		if(Input.GetKey("s")){
			transform.Translate((Vector3.back)*moveSpeed*Time.deltaTime);
			Debug.Log("Pressing S key");
		}
		if(Input.GetKey("a")){
			transform.Rotate(Vector3.down * rotateSpeed);
			Debug.Log("Pressing A key");
		}
		if(Input.GetKey("d")){
			transform.Rotate(Vector3.up * rotateSpeed);
			Debug.Log("Pressing A key");
		}
	
	}
}
