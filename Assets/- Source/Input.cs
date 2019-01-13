using System;
using UnityEngine;
using Rewired;

public class Input : MonoBehaviour {

	const int PLAYER_ID = 0;
	string[] limbs = new string[]{"FL", "FR", "BL", "BR"};

	// ------------------------------------------------------------------------

	void Update(){
		foreach(string k in limbs){
			this.Find(k).Get<Flap>().enabled = player.GetButton(k);
		}
	}

	/*
	public static bool GetKey(string action){
		return player.GetButton(action) || AlwaysOn(action);
	}

	public static bool GetKeyDown(string action){
		return player.GetButtonDown(action) || AlwaysOn(action);
	}

	public static bool GetKeyUp(string action){
		return player.GetButtonUp(action);
	}

	// Support mouse look equiv with controllers
	public static float GetAxis(string axis){
		return Input.GetAxis(axis) + player.GetAxis(axis);
	}

	public static float HorizontalAxis{ get{
		return Input.GetAxis("Horizontal") + player.GetAxis("Move");
	}}

	public static float VerticalAxis{ get{
		return Input.GetAxis("Vertical") + player.GetAxis("Strafe");
	}}
	*/
	// ------------------------------------------------------------------------

	static Player player{ get{ return ReInput.players.GetPlayer(PLAYER_ID); }}

}
