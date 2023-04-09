using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Managers;
using UnityEngine;

public class Npc4Reaction : MonoBehaviour
{
    [SerializeField] private GameObject Panel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Question4)
        {
           Panel.SetActive(true); 
        }

        if (KeyManager.Instance.key4bool)
        {
            Panel.SetActive(false);
        }
    }
}
