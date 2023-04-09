using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.tag)
        {
            case "Start":
                SceneManager.LoadScene("Game");
                break;
            case "Credits":
                SceneManager.LoadScene("Credits");
                break;
            case "Sound":
                break;
            case "Exit":
                Application.Quit();
                break;
        }
    }
}
