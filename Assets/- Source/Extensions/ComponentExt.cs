using UnityEngine;

public static class ComponentExt {

	public static C Req<C>(this Component x) where C : Component{
		var c = x.GetComponent<C>();
		return c ? c : x.gameObject.AddComponent<C>();
	}

	public static C Get<C>(this Component x) where C : Component{
        return x.GetComponent<C>();
    }
}
