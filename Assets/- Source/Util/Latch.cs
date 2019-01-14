using UnityEngine;

public class Latch : MonoBehaviour {

	public string _tag = "Player";
	public bool isSet = false;
	public AudioSource[] audioToStop;

	void OnTriggerEnter(Collider that){
		if(!that.CompareTag(_tag))return;
		if(!isSet){
			var audio = this.Get<AudioSource>();
			if(audio) audio.Play();
			foreach(AudioSource s in audioToStop){
				s.Stop();
			}
		}
		isSet = isSet || that.CompareTag(_tag);
	}

}
