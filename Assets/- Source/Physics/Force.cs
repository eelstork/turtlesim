using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour {

	public Transform origin;
	public Vector3 direction = Vector3.down;
	public float amount = 10f;

	void FixedUpdate(){
		var f = direction*amount; if(origin)
			body.AddForceAtPosition(f, origin.position);
		else
			body.AddForce(f);
	}

	Rigidbody body{get{ return GetComponent<Rigidbody>(); }}

}
