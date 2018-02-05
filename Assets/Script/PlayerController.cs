using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {
	// speedを制御する
	public float speed = 10;
	public VirtulJoyStick movejoystick;

	void FixedUpdate ()
	{
		float x =  Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		float dx = movejoystick.Horizontal ();
		float dz = movejoystick.Vertical ();

		Rigidbody rigidbody = GetComponent<Rigidbody>();

		// xとyにspeedを掛ける
		rigidbody.AddForce(x * speed, 0, z * speed);
		rigidbody.AddForce(dx * speed, 0, dz * speed);
	}
}
