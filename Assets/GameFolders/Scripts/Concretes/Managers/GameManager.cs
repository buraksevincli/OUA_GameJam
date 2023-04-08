using System;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; set; }
        
        public bool Question1 { get; set; }
        
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
}

