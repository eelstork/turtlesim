using UnityEngine;
using UnityEditor;

public static class BehaviourExt{

    public static C Req<C>(this MonoBehaviour x) where C : Component{
        var c = x.GetComponent<C>();
        return c ? c : x.gameObject.AddComponent<C>();
    }

    public static Material DefaultMaterial(this MonoBehaviour x){
        return AssetDatabase.GetBuiltinExtraResource<Material>(
            "Default-Diffuse.mat");
    }

    public static GameObject Find(this MonoBehaviour x, string s){
        return GameObject.Find(s);
    }

}
