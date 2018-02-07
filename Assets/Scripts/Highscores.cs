using UnityEngine;
using UnityEngine.UI;

public class Highscores : MonoBehaviour {

    public Text highScore;

    void Start()
    {
        highScore.text = "1. " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
}
