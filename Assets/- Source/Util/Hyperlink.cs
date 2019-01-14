using UnityEngine;

public class Hyperlink : MonoBehaviour {

	public string url = "https://www.facebook.com/Anime.3D.SFX";
	public void Open(){
		print("Open hyperlink: " + url); Application.OpenURL (url);
	}

}
