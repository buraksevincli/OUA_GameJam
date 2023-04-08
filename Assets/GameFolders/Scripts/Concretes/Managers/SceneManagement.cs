using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "home1":
                SceneManager.LoadScene(1);
                break;

            case "home2":
                SceneManager.LoadScene(2);
                break;

            case "home3":
                SceneManager.LoadScene(3);
                break;

            case "home3_basement":
                SceneManager.LoadScene(4);
                break;

            case "home4":
                SceneManager.LoadScene(5);
                break;

            case "home5":
                SceneManager.LoadScene(6);
                break;

            case "MainBuilding":
                SceneManager.LoadScene(7);
                break;

            case "Storage":
                SceneManager.LoadScene(8);
                break;

            case "main":
                SceneManager.LoadScene(0);
                break;
        }
        
    }
}
