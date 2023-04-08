using System;
using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Managers;
using Unity.VisualScripting;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject item;
    
    private void OnTriggerStay2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            panel.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                item.SetActive(true);
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            panel.SetActive(false);
        }
    }
    
}

