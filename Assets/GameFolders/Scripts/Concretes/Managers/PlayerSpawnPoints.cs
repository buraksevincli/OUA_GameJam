using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using GameFolders.Scripts.Concretes.Managers;

public class PlayerSpawnPoints : MonoBehaviour
{
    [SerializeField] GameObject spawn_point_ref;
    void Start()
    {
        transform.position = new Vector3(spawn_point_ref.transform.position.x, spawn_point_ref.transform.position.y,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void get_ref_point()
    {
        
    }
}
