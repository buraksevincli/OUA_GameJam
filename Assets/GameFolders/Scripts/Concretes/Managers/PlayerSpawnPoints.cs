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
                    GameManager.Instance.PlayerAnswer = false;
                    home1.SetActive(true);
                    Destroy(npc1.GetComponent<BoxCollider2D>());
                    break;

                case "NPC2":
                    GameManager.Instance.Question2 = true;
                    GameManager.Instance.PlayerAnswer = false;
                    home2.SetActive(true);
                    Destroy(npc2.GetComponent<BoxCollider2D>());
                    break;

                case "NPC3":
                    GameManager.Instance.Question3 = true;
                    GameManager.Instance.PlayerAnswer = false;
                    home3.SetActive(true);
                    Destroy(npc3.GetComponent<BoxCollider2D>());
                    break;

                case "NPC4":
                    GameManager.Instance.Question4 = true;
                    GameManager.Instance.PlayerAnswer = false;
                    home4.SetActive(true);
                    Destroy(npc4.GetComponent<BoxCollider2D>());
                    break;

                case "NPC5":
                    GameManager.Instance.Question5 = true;
                    GameManager.Instance.PlayerAnswer = false;
                    home5.SetActive(true);
                    Destroy(npc5.GetComponent<BoxCollider2D>());
                    break;

                case "NPC6":
                    GameManager.Instance.Question6 = true;
                    GameManager.Instance.PlayerAnswer = false;
                    Storage.SetActive(true);
                    Destroy(npc6.GetComponent<BoxCollider2D>());
                    break;

                case "NPC7":
                    GameManager.Instance.Question7 = true;
                    GameManager.Instance.PlayerAnswer = false;
                    MainBuilding.SetActive(true);
                    Destroy(npc7.GetComponent<BoxCollider2D>());
                    break;
            }
        }
        
    }
}
