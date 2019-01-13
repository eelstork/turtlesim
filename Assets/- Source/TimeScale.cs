using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScale : MonoBehaviour {

	public float scale = 2;

	void Update () { Time.timeScale = scale; }
}
