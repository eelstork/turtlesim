using UnityEngine;

public class Velocity : MonoBehaviour {

    public Vector3 velocity;
    public float speed;

    void Update(){
        velocity = this.Get<Rigidbody>().velocity;
        speed = velocity.magnitude;
    }

}
