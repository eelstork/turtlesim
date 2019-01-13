using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : MonoBehaviour {

	public float traction = 1;
	public float scalar   = 5;

	void Update(){
		foreach(Flap f in GetComponentsInChildren<Flap>()){
			f.traction = traction;
			f.scalar = scalar;
		}
	}

}
