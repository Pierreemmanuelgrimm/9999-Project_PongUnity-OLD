using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float playerForce = 200f;
    Vector3 lastPosition;
	// Update is called once per frame
	void FixedUpdate () {
        lastPosition = transform.position;
        if (Input.GetKey("a"))
        {
            //transform.Translate(0, 0, playerForce * Time.deltaTime);
            GetComponent<Rigidbody>().AddForce(0, 0, playerForce*Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            //transform.Translate(0, 0, -playerForce * Time.deltaTime);
            GetComponent<Rigidbody>().AddForce(0, 0, -playerForce * Time.deltaTime, ForceMode.VelocityChange);
        }
    }

}
