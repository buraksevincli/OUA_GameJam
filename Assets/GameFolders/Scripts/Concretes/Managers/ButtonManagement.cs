using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManagement : MonoBehaviour
{
    public bool Question_controller;

    [SerializeField] private GameObject button;
    public void questionController()
    {
        Question_controller = true;
    }
}
