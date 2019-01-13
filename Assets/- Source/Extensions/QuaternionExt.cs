using UnityEngine;

public static class QuaternionExt{

	public static float Serial(this Quaternion q) {
		return q.w + q.x + q.y + q.z;
	}

}
