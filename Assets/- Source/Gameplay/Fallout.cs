using UnityEngine;
using UnityEngine.SceneManagement;

public class Fallout : MonoBehaviour {

	void Update () {
		if(speed>100){
			SceneManager.LoadScene(0);
			DestroyImmediate(this);
		}
		pixelation = 1 + (int)(speed/3);
	}

	float speed{get{ return this.Find<Velocity>().speed; }}

	int pixelation{set{ this.Find<Pixelate>().pixelSizeX = value; }}

}
