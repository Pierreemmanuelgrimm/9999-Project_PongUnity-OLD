using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int playerScore;
    public int aiScore;


    public Text scoreboard;
	// Use this for initialization
	void Start () {
        playerScore = 0;
        aiScore = 0;
        UpdateScore();
	}
	
	// Update is called once per frame
	void Update () {
	}
    public void UpdateScore()
    {
        if (playerScore == 10 || aiScore == 10) EndGame();
        scoreboard.text = playerScore + " : " + aiScore;
    }
    void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
