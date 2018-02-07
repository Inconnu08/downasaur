using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public Transform player;
    public float restartLevel = 2f;
    public GameObject retryUI;

    float prevScore;

    void Start()
    {
        prevScore = PlayerPrefs.GetInt("HighScore", 0);
    }

	public void EndGame()
    {
        Debug.Log("===GAME OVER!===");
        if (gameHasEnded == false)
        {
            Debug.Log("***GAME OVER!***");
            gameHasEnded = true;
            Debug.Log("Current Score: "+ player.position.z +"\n from pref: "+ PlayerPrefs.GetInt("HighScore", 0));
            if (player.position.z > prevScore)
            {
                PlayerPrefs.SetInt("HighScore", (int)player.position.z);
            }
        }   
    }

    void Restart()
    {
        // Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        if (gameHasEnded == true)
        {
            retryUI.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                // Debug.Log("***Restarting level***");
                Invoke("Restart", restartLevel);
            }
        }      
    }
}
