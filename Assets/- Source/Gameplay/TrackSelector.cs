using UnityEngine;

public class TrackSelector : MonoBehaviour {

	public GameObject[] tracks;
	public int index = 0;

	void Start(){
		for(int i=0; i<tracks.Length; i++) tracks[i].SetActive(i==index);
	}

}
