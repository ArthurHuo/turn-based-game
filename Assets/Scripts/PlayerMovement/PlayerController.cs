using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float rotateSpeed = 5.0f;
	public float forwardSpeed = 5.0f;
	private float runSpeed;
	private CharacterController playerController;

	// Use this for initialization
	void Start () {
		playerController = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space") && playerController.isGrounded){
			playerController.Move(Vector3.up);
		}
		transform.Rotate (0,Input.GetAxis("Horizontal")*rotateSpeed,0); //Vector3 = x,y,x
		Vector3 forward = transform.TransformDirection (Vector3.forward);
		float speed = forwardSpeed * Input.GetAxis ("Vertical");
		playerController.SimpleMove (speed*forward);

		if(Input.GetAxis("Run") == 1 && playerController.isGrounded){
			runSpeed = forwardSpeed * 1.5f;
			forwardSpeed = runSpeed;
		}
	}
}
