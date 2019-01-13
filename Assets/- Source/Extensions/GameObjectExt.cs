using UnityEngine;

public static class GameObjectExt {

	public static C Req<C>(this GameObject x) where C : Component{
		var c = x.GetComponent<C>();
		return c ? c : x.AddComponent<C>();
	}

	public static C Get<C>(this GameObject x) where C : Component{
        return x.GetComponent<C>();
    }

}
