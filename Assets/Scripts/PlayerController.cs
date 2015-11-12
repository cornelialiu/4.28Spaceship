using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float tilt;
	public Boundary boundary;
	private int count;

	public Text countText;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public SimpleTouchPad touchPad;
	
	private float nextFire;
	private Quaternion calibrationQuaternion;

	void Start()
	{
		CalibrateAccelerometer ();
		count = 0;
		SetCountText ();
	}
	void Update ()
	{
		//if (Input.GetButton("Fire1") && Time.time > nextFire)
		//{
		//	nextFire = Time.time + fireRate;
			//Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		//}
	}

	//Used to calibrate the Input.acceleration input
	void CalibrateAccelerometer () {
		Vector3 accelerationSnapshot = Input.acceleration;
		Quaternion rotateQuaternion = Quaternion.FromToRotation (new Vector3 (0.0f, 0.0f, -1.0f), accelerationSnapshot);
		calibrationQuaternion = Quaternion.Inverse (rotateQuaternion);
	}

	//Get the calibrated value from the Input
	Vector3 FixAcceleration (Vector3 acceleration) {
		Vector3 fixedAcceleration = calibrationQuaternion * acceleration;
		return fixedAcceleration;
	}
	
	void FixedUpdate ()
	{
		/* ********************************************************
		 * This is used for keyboard inputs
		//float moveHorizontal = Input.GetAxis ("Horizontal");
		//float moveVertical = Input.GetAxis ("Vertical");
		//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		************************************************************
		*/


		//This is used for accelerometer input

		//Vector3 accelerationRaw = Input.acceleration;
		//Vector3 acceleration = FixAcceleration (accelerationRaw);
		//Vector3 movement = new Vector3 (acceleration.x, 0.0f, acceleration.y);

		// end of the accelerometer input

		// This is used for the joystck
		Vector2 direction = touchPad.GetDirection ();
		Vector3 movement = new Vector3 (direction.x, 0.0f, direction.y);
		// end of joystick

		GetComponent<Rigidbody>().velocity = movement * speed;
		
		GetComponent<Rigidbody>().position = new Vector3 
			(
				Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), 
				0.0f, 
				Mathf.Clamp (GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
				);
		
		GetComponent<Rigidbody>().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary") 
		{
			return;
		}
		if (other.tag == "Astroid") 
		{
			count = count + 1;
			SetCountText ();
		}

	}

	void SetCountText()
	{
		countText.text = "Count: " + count.ToString ();

	}
}