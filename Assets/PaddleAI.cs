using UnityEngine;

public class PaddleAI : MonoBehaviour {
    public Transform ball;
    public float gain = 0.1f;
	
	// Update is called once per frame
	void FixedUpdate () {
        float f = gain * (ball.position.z - transform.position.z);
        GetComponent<Rigidbody>().AddForce(0,0,f*Time.deltaTime,ForceMode.VelocityChange);
    }
}
