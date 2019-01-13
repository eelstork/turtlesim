using UnityEngine;

public static class Vector3Ext{

	public static float Serial(this Vector3 u) {
		return u.x + u.y + u.z;
	}

	// ... doesn't work, but why?
	// public static void SetLength(this Vector3 self, Vector3 that){
	// 	self.Normalize(); self *= (that.magnitude);
	// }

}
