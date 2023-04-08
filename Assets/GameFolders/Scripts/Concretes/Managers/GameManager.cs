using System;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Managers
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] GameObject home1;
        [SerializeField] GameObject home2;
        [SerializeField] GameObject home3;
        [SerializeField] GameObject home4;
        [SerializeField] GameObject home41;
        [SerializeField] GameObject home5;
        [SerializeField] GameObject MainBuilding;
        [SerializeField] GameObject MainBuildingv2;
        [SerializeField] GameObject storage;
        public static GameManager Instance { get; set; }

        public bool Question1 { get; set; }
        public Vector3 player_position { get; set;}
        public Vector3 home1_vector { get; set; }
        public Vector3 home2_vector { get; set; }
        public Vector3 home3_vector { get; set; }
        public Vector3 home4_vector { get; set; }
        public Vector3 home5_vector { get; set; }
        public Vector3 MainBuilding_vector { get; set; }
        public Vector3 storage_vector { get; set; }


        private void Start()
        {
            home4_vector = home4.transform.position;
            storage_vector = storage.transform.position;
            home1_vector = home1.transform.position;
            home2_vector = home2.transform.position;
            home3_vector = home3.transform.position;
            home5_vector = home5.transform.position;
            MainBuilding_vector = MainBuilding.transform.position;
        }
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

