﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

    public void Back()
    {
        Debug.Log("Back");
        SceneManager.LoadScene(0);
    }
}
