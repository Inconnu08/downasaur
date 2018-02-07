using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour {

    public Text graphics;
    public Text music;

    int highGraphics;


    void Start()
    {
        int highGraphics = PlayerPrefs.GetInt("HighGraphics", 0);
        Debug.Log("From gfx settings: " + highGraphics);
        int music = PlayerPrefs.GetInt("Music", 0);

    }

    public void HighGraphics()
    {
            Debug.Log("Settings: Graphics High.");
            PlayerPrefs.SetInt("HighGraphics", 1);
            highGraphics = 1;
    }

    public void LowGraphics()
    {
            Debug.Log("Settings: Graphics Low.");
            PlayerPrefs.SetInt("HighGraphics", 0);
            highGraphics = 0;
    }

    void Update()
    {
        highGraphics = PlayerPrefs.GetInt("HighGraphics", 0);
        if (highGraphics == 1)
        {
            graphics.text = "High";
        }
        else
        {
            graphics.text = "Low";
        }
    }

    public void GraphicsToggle()
    {
        if(highGraphics == 1)
        {
            LowGraphics();
        }
        else
        {
            HighGraphics();
        }
    }
}
