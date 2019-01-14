using UnityEngine;

public class LookAt : MonoBehaviour {

	public float w = 0f;
	public float wMax = 0.01f;
	public Transform target;

	void Update(){
		var t = transform;
		var u = target.position - transform.position;
		var v = Vector3.Lerp(t.forward, u, w);
		transform.forward = v;
		w+=0.000001f; if(w>wMax) w=wMax;
	}

}
