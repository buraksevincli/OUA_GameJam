using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Managers;
using UnityEngine;

public class Npc2Reaction : MonoBehaviour
{
    [SerializeField] private GameObject Panel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Question2)
        {
           Panel.SetActive(true); 
        }

        if (KeyManager.Instance.key2bool)
        {
            Panel.SetActive(false);
        }
    }
}
