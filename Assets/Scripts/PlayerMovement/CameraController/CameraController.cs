using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform cameraTarget;
	private float x = 0.0f;
	private float y = 0.0f;

	private int mouseXSpeedMod = 5;
	private int mouseYSpeedMode = 3;

	public float maxViewDistance = 25; //how far will the camera will zoom out
	public float minViewDistance = 1; //how close the camera will zoom in
	public int zoomRate = 30; //how fast the camera will zoom
	private int lerpRate = 5;
	private float distance = 3; //starting distance away from the player
	private float desiredDistance; //used for calculation
	private float correctedDistance; //used for calculation
	private float currentDistance;

	public float cameraTargetHeight = 1.0f;

	// Use this for initialization
	void Start () {
		Vector3 angles = transform.eulerAngles;
		x = angles.x;
		y = angles.y;

		currentDistance = distance;
		desiredDistance = distance;
		correctedDistance = distance;
	}
	
	// Update after update function,since our camera controller is not as important as our movement, we want our movement occur first
	void LateUpdate () {
		if(Input.GetMouseButton(1)){ //0 is the left mouse button
			//Debug.Log("aaa");
			x += Input.GetAxis("Mouse X") * mouseXSpeedMod;
			y -= Input.GetAxis("Mouse Y") * mouseYSpeedMode;
		}else if(Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0){// if either vertical or horizontal key passed, the code below will excute
			float targetRotationAngle = cameraTarget.eulerAngles.y;
			float cameraRotationAngle = transform.eulerAngles.y;
			x = Mathf.LerpAngle(cameraRotationAngle,targetRotationAngle,lerpRate * Time.deltaTime);
		}

		y = ClampAngle (y,-50,80);
		Quaternion rotation = Quaternion.Euler (y,x,0);
		desiredDistance -= Input.GetAxis ("Mouse ScrollWheel") * Time.deltaTime * zoomRate * Mathf.Abs(desiredDistance); //calculate the distance the player wants their camera
		desiredDistance = Mathf.Clamp (desiredDistance,minViewDistance,maxViewDistance);
		correctedDistance = desiredDistance;

		Vector3 position = cameraTarget.position - (rotation * Vector3.forward * desiredDistance); //(x,y,z) * (0,1,0) * angle in degrees

		RaycastHit collisionHit;
		Vector3 cameraTargetPostion = new Vector3 (cameraTarget.position.x, cameraTarget.position.y + cameraTargetHeight, cameraTarget.position.z);

		bool isCorrected = false;
		if(Physics.Linecast(cameraTargetPostion,position,out collisionHit)){
			position = collisionHit.point;
			correctedDistance = Vector3.Distance(cameraTargetPostion,position);
			isCorrected = true;
		}

		currentDistance = !isCorrected || correctedDistance > currentDistance ? Mathf.Lerp (currentDistance, correctedDistance, Time.deltaTime * zoomRate) : correctedDistance;

		position = cameraTargetPostion - (rotation * Vector3.forward * currentDistance + new Vector3(0,-cameraTargetHeight,0));

		transform.rotation = rotation; //when you call transform within the script, the script looks for the transfrom the script attached too
		transform.position = position;
	}
	private static float ClampAngle(float angle, float min, float max){
		if(angle < -360){
			angle += 360;
		}
		if(angle > 360){
			angle -= 360;
		}
		return Mathf.Clamp (angle,min,max);
	}
}
