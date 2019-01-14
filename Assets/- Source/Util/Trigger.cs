using UnityEngine;

public class Trigger : MonoBehaviour {

	public enum Status{ WAITING, SET, BURNED }
	public string _tag = "Player";
	public Status status = Status.WAITING;
	[Header("Info")]
	public Collider collider;

	public bool isSet{get{
		if(status != Status.SET) return false;
		status = Status.BURNED;
		return true;
	}}

	void OnTriggerEnter(Collider that){
		if(status != Status.WAITING) return;
		if(!that.CompareTag(_tag))   return;
		status = Status.SET;
		CheckForHyperlink();
	}

	void CheckForHyperlink(){
		var h = this.Get<Hyperlink>();
		if(h){
			status = Status.BURNED;
			h.Open();
		}else{
			print("No hyperlnk");
		}
	}

}
