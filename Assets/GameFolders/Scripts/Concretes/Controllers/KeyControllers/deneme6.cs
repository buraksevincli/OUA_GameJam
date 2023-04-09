using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Managers;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class deneme6 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (KeyManager.Instance.key7bool)
        {
            gameObject.GetComponent<Image>().enabled = true;
        }
        
    }
}
