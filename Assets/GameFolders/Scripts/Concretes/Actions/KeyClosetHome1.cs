using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KeyClosetHome1 : MonoBehaviour
{
    private bool cond = false;
    [SerializeField] private GameObject key, Closedcloset;
    void Start()
    {
        
    }

    IEnumerator KeyImageTimer()
    {
        key.SetActive(true); 
        yield return new WaitForSeconds(2f);
        key.SetActive(false);
        
    }
    

    // Update is called once per frame
    void OnEnable()
    {
        if(Closedcloset.GetComponent<Interaction>().opened == true)
        {
            cond = true;

        }
        if (cond)
        {
            StartCoroutine(KeyImageTimer());
        }
    }
    
}
