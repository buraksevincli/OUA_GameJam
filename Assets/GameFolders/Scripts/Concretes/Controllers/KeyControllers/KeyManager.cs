using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

namespace GameFolders.Scripts.Concretes.Managers
{
   public class KeyManager : MonoBehaviour
   {
      public static KeyManager Instance { set; get; }
      
      public bool key1bool { set; get; }
      public bool key2bool { set; get; }
      public bool key3bool { set; get; }
      public bool key4bool { set; get; }
      public bool key5bool { set; get; }
      public bool key6bool { set; get; }
      public bool key7bool { set; get; }

      


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
