using UnityEngine;
using UnityEditor;

public static class BehaviourExt{

    public static C Find<C>(this MonoBehaviour x) where C : Component{
        return GameObject.FindObjectOfType<C>();
    }

    public static GameObject Find(this MonoBehaviour x, string s){
        return GameObject.Find(s);
    }

    public static C Find<C>(this MonoBehaviour x, string s) where C : Component{
        return GameObject.Find(s).GetComponent<C>();
    }

    public static C Get<C>(this MonoBehaviour x) where C : Component{
        return x.GetComponent<C>();
    }

    public static C Req<C>(this MonoBehaviour x) where C : Component{
        var c = x.GetComponent<C>();
        return c ? c : x.gameObject.AddComponent<C>();
    }

}
