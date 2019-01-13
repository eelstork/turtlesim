using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour {

	//public Transform origin;
	public Vector3 direction = Vector3.forward;
	public float amount = 10f;

	void FixedUpdate(){
		body.AddTorque(direction*amount);
	}

	Rigidbody body{get{ return GetComponent<Rigidbody>(); }}

}
