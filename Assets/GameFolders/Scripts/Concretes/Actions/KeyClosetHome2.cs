using System.Collections;
using System.Collections.Generic;
using GameFolders.Scripts.Concretes.Managers;
using Unity.VisualScripting;
using UnityEngine;

public class KeyClosetHome2 : MonoBehaviour
{
    private bool cond = false;
    [SerializeField] private GameObject key, Closedcloset;
    
    IEnumerator KeyImageTimer()
    {
        
            key.SetActive(true);
            KeyManager.Instance.key2bool = true;
            yield return new WaitForSeconds(2f);
            key.SetActive(false);
            



    }
    void OnEnable()
    {
        if(Closedcloset.GetComponent<Interaction>().opened == true && KeyManager.Instance.key2bool != true)
        {
            cond = true;
        }
        if (cond )
        {
            StartCoroutine(KeyImageTimer());
        }
    }
    
    
}
