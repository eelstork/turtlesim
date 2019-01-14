using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Race : MonoBehaviour {

	Latch start, end;
	Trigger retry;
	bool ended = false;
	StopWatch stopWatch;

	void Start(){
		start = this.Find<Latch>("Start");
		end   = this.Find<Latch>("End");
		retry = this.Find<Trigger>("Retry");
	}

	void Update () {
		if(retry.isSet) SceneManager.LoadScene(0);
		if(start.isSet && stopWatch==null) stopWatch = this.Req<StopWatch>();
		if(end.isSet && !ended){
			ended = true;
			stopWatch.Stop();
			gameObject.AddComponent<Finish>();
		}
	}

}
