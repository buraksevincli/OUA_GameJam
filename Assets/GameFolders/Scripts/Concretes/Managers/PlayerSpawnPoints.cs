using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using GameFolders.Scripts.Concretes.Managers;

public class PlayerSpawnPoints : MonoBehaviour
{
    [SerializeField] GameObject questionController;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (questionController==true)
        {
            switch (collision.tag)
            {
                case "NPC1":
                    GameManager.Instance.Question1 = true;
                    Debug.Log("question1=true");
                    break;

                case "NPC2":
                    GameManager.Instance.Question1 = true;
                    Debug.Log("question2=true");
                    break;

                case "NPC3":
                    GameManager.Instance.Question1 = true;
                    Debug.Log("question3=true");
                    break;

                case "NPC4":
                    GameManager.Instance.Question1 = true;
                    Debug.Log("question4=true");
                    break;

                case "NPC5":
                    GameManager.Instance.Question1 = true;
                    Debug.Log("question5=true");
                    break;

                case "NPC6":
                    GameManager.Instance.Question1 = true;
                    Debug.Log("question6=true");
                    break;

                case "NPC7":
                    GameManager.Instance.Question1 = true;
                    Debug.Log("question7=true");
                    break;
            }
        }
        
    }
}
