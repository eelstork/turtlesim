using UnityEngine;

public class StopWatch : MonoBehaviour{

	public float start, status, end;

	void Awake()       { start = Time.time; status = end = 0;     }
	void Update()      { if(end <= 0) status = Time.time - start; }
	public void Stop() { end = Time.time; status = end-start;     }

}
