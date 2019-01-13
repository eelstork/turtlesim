using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flap : MonoBehaviour {

	//public Transform origin;
	public Vector3 direction = Vector3.forward;
	public float amount = 10f;
	public float scalar = 1f;

	[Header("Info")]
	public float output;

	void FixedUpdate(){
		var u = transform.parent.TransformDirection(direction);
		output = amount*Mathf.Cos(Time.time*scalar);
		body.AddTorque(direction*output);
	}

	Rigidbody body{get{ return GetComponent<Rigidbody>(); }}

}
