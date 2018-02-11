using UnityEngine;

public class BallMovement : MonoBehaviour {

    public float initVelocity = 500f;
    public float startDelay = 1f;
    public GameManager gameManager;
    // Use this for initialization
    
    void Start () {
        Reset();
    }
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x < -30)
        {
            gameManager.aiScore++;
            gameManager.UpdateScore();
            Reset();
        }
        if(transform.position.x > 30)
        {
            gameManager.playerScore++;
            gameManager.UpdateScore();
            Reset();
        }
    }
    void Reset()
    {
        transform.position = new Vector3(0f, 1f, 0f);
        GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        Invoke("ResetVelocity", startDelay);
    }
    void ResetVelocity()
    {
        float initAngle = (Mathf.PI/4) + (Random.value - 0.5f) * Mathf.PI / 16;
        if (Random.value >= 0.5) initAngle += Mathf.PI / 2;
        if (Random.value >= 0.5) initAngle += Mathf.PI;
        GetComponent<Rigidbody>().velocity = new Vector3(initVelocity * Mathf.Cos(initAngle), 0, initVelocity * Mathf.Sin(initAngle));
    }

}
