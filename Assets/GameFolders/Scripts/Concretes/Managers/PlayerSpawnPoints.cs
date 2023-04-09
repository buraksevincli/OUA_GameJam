using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using GameFolders.Scripts.Concretes.Managers;

public class PlayerSpawnPoints : MonoBehaviour
{
    [SerializeField] GameObject questionController;
    [SerializeField] GameObject npc1;
    [SerializeField] GameObject npc2;
    [SerializeField] GameObject npc3;
    [SerializeField] GameObject npc4;
    [SerializeField] GameObject npc5;
    [SerializeField] GameObject npc6;
    [SerializeField] GameObject npc7;
    [SerializeField] GameObject home1;
    [SerializeField] GameObject home2;
    [SerializeField] GameObject home3;
    [SerializeField] GameObject home4;
    [SerializeField] GameObject home5;
    [SerializeField] GameObject Storage;
    [SerializeField] GameObject MainBuilding;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (questionController.GetComponent<ButtonManagement>().Question_controller==true)
        {
            switch (collision.tag)
            {
                case "NPC1":
                    GameManager.Instance.Question1 = true;
                    home1.SetActive(true);
                    Destroy(npc1.GetComponent<BoxCollider2D>());
                    Debug.Log("question1=true");
                    break;

                case "NPC2":
                    GameManager.Instance.Question2 = true;
                    home2.SetActive(true);
                    Destroy(npc2.GetComponent<BoxCollider2D>());
                    Debug.Log("question2=true");
                    break;

                case "NPC3":
                    GameManager.Instance.Question3 = true;
                    home3.SetActive(true);
                    Destroy(npc3.GetComponent<BoxCollider2D>());
                    Debug.Log("question3=true");
                    break;

                case "NPC4":
                    GameManager.Instance.Question4 = true;
                    home4.SetActive(true);
                    Destroy(npc4.GetComponent<BoxCollider2D>());
                    Debug.Log("question4=true");
                    break;

                case "NPC5":
                    GameManager.Instance.Question5 = true;
                    home5.SetActive(true);
                    Destroy(npc5.GetComponent<BoxCollider2D>());
                    Debug.Log("question5=true");
                    break;

                case "NPC6":
                    GameManager.Instance.Question6 = true;
                    Storage.SetActive(true);
                    Destroy(npc6.GetComponent<BoxCollider2D>());
                    Debug.Log("question6=true");
                    break;

                case "NPC7":
                    GameManager.Instance.Question7 = true;
                    MainBuilding.SetActive(true);
                    Destroy(npc7.GetComponent<BoxCollider2D>());
                    Debug.Log("question7=true");
                    break;
            }
        }
        
    }
}
