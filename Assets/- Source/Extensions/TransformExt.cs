using UnityEngine;

public static class TransformExt{

    public static void Clear(this Transform x) {
        x.localPosition = Vector3.zero;
        x.localRotation = Quaternion.identity;
        x.localScale    = Vector3.one;
    }
    
	public static float Serial(this Transform x){
		return x.localPosition.Serial()
			+ x.localRotation.Serial()
			+ x.localScale.Serial();
	}

}
