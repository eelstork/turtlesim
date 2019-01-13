using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MatrixExt {

	public static Matrix4x4 Add(this Matrix4x4 a, Matrix4x4 b) {
		var c = Matrix4x4.identity;
		for(int i=0;i<4;i++) c.SetColumn(i, a.GetColumn(i)+b.GetColumn(i));
		return c;
	}

	public static void DebugDraw(this Matrix4x4 M, float s = 0.1f) {
		Vector3 O = M.Position();
		Debug.DrawRay(O, M.X()*s, Color.red);
		Debug.DrawRay(O, M.Y()*s, Color.green);
		Debug.DrawRay(O, M.Z()*s, Color.blue);
	}

	public static void DebugDraw(this Matrix4x4 M, Transform T,
								 float s = 0.1f) {
		Vector3 O = M.Position(T);
		Debug.DrawRay(O, M.X(T)*s, Color.red);
		Debug.DrawRay(O, M.Y(T)*s, Color.green);
		Debug.DrawRay(O, M.Z(T)*s, Color.blue);
	}

	public static Matrix4x4 Local(Transform t){
		return Matrix4x4.TRS(t.localPosition, t.localRotation, t.localScale);
	}

	public static Matrix4x4 Mul(this Matrix4x4 a, float s) {
		var c = Matrix4x4.identity;
		for(int i=0;i<4;i++) c.SetColumn(i, a.GetColumn(i)*s);
		return c;
	}

	public static Vector3 Position(this Matrix4x4 M){ return M.GetColumn(3); }

	public static Vector3 Position(this Matrix4x4 M, Transform T){
		return T.TransformPoint(M.GetColumn(3));
	}

	public static Matrix4x4 Set(this Matrix4x4 M, Vector4 X, Vector3 Y,
								 Vector3 Z, Vector3 P){
		return M.SetX(X).SetY(Y).SetZ(Z).SetPosition(P);
	}

	public static Matrix4x4 SetX(this Matrix4x4 M, Vector4 X){
		M.SetColumn(0, X); return M;
	}

	public static Matrix4x4 SetY(this Matrix4x4 M, Vector4 Y){
		M.SetColumn(1, Y); return M;
	}

	public static Matrix4x4 SetZ(this Matrix4x4 M, Vector4 Z){
		M.SetColumn(2, Z); return M;
	}

	public static Matrix4x4 SetPosition(this Matrix4x4 M, Vector4 P){
		M.SetColumn(3, P); return M;
	}

	public static Matrix4x4 Sub(this Matrix4x4 a, Matrix4x4 b) {
		var c = Matrix4x4.identity;
		for(int i=0;i<4;i++) c.SetColumn(i, a.GetColumn(i)-b.GetColumn(i));
		return c;
	}

	public static Vector3 X(this Matrix4x4 M){ return M.GetColumn(0); }
	public static Vector3 X(this Matrix4x4 M, Transform T){
		return T.TransformDirection(M.GetColumn(0));
	}

	public static Vector3 Y(this Matrix4x4 M){ return M.GetColumn(1); }

	public static Vector3 Y(this Matrix4x4 M, Transform T){
		return T.TransformDirection(M.GetColumn(1));
	}

	public static Vector3 Z(this Matrix4x4 M){ return M.GetColumn(2); }

	public static Vector3 Z(this Matrix4x4 M, Transform T){
		return T.TransformDirection(M.GetColumn(2));
	}

}
