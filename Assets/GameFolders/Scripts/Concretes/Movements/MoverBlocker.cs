using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBlocker : MonoBehaviour
{
    public static MoverBlocker Instance { get; set; }

    public bool PlayerAnswer { get; set; }

    private void Awake()
    {
        SingletonThisObject();
    }

    private void SingletonThisObject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
