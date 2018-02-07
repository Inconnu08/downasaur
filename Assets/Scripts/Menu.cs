using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    int highGraphics;
    int music;

    public PostProcessingProfile ppProfile; // post processing effects

    void Start()
    {
        highGraphics = PlayerPrefs.GetInt("HighGraphics", 0);
        music = PlayerPrefs.GetInt("Music", 0);
    }

    void Update()
    {
        if (highGraphics == 1)
        {
            ppProfile.colorGrading.enabled = true;
            ppProfile.vignette.enabled = true;
        }
        else
        {
            ppProfile.colorGrading.enabled = false;
            ppProfile.vignette.enabled = false;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Credits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void HighScore()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void Settings()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
}
