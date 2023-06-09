using GameFolders.Scripts.Concretes.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionManagement : MonoBehaviour
{
    private bool question1Bool;
    private bool question2Bool;
    private bool question3Bool;
    private bool question4Bool;
    private bool question5Bool;
    private bool question6Bool;
    private bool question7Bool;
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
    [SerializeField] GameObject home6;
    [SerializeField] GameObject home7;
    void Start()
    {
        question1Bool = GameManager.Instance.Question1;
        question2Bool = GameManager.Instance.Question2;
        question3Bool = GameManager.Instance.Question3;
        question4Bool = GameManager.Instance.Question4;
        question5Bool = GameManager.Instance.Question5;
        question6Bool = GameManager.Instance.Question6;
        question7Bool = GameManager.Instance.Question7;
        if (question1Bool==true)
        {
            Destroy(npc1.GetComponent<BoxCollider2D>());
            home1.SetActive(true);
        }

        if (question2Bool == true)
        {
            Destroy(npc2.GetComponent<BoxCollider2D>());
            home2.SetActive(true);
        }

        if (question3Bool == true)
        {
            Destroy(npc3.GetComponent<BoxCollider2D>());
            home3.SetActive(true);
        }

        if (question4Bool == true)
        {
            Destroy(npc4.GetComponent<BoxCollider2D>());
            home4.SetActive(true);
        }

        if (question5Bool == true)
        {
            Destroy(npc5.GetComponent<BoxCollider2D>());
            home5.SetActive(true);
        }

        if (question6Bool == true)
        {
            Destroy(npc6.GetComponent<BoxCollider2D>());
            home6.SetActive(true);
        }

        if (question7Bool == true)
        {
            Destroy(npc7.GetComponent<BoxCollider2D>());
            home7.SetActive(true);
        }
    }
}
