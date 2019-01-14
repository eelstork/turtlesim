using UnityEngine;
using UnityEngine.UI;

public class InfoDisplay : MonoBehaviour {

	void Update () {
		var w = this.Find<StopWatch>();
		if(w)
			this.Get<Text>().text = string.Format("TIME: {0:00.00}", w.status);
	}

}
