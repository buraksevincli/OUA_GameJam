using GameFolders.Scripts.Concretes.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    [SerializeField] GameObject Player_object;
    private Vector3 sample;
    void Start()
    {
        sample = new Vector3(Player_object.transform.position.x,Player_object.transform.position.y,0f);
        if (GameManager.Instance.player_position.x == 0 && GameManager.Instance.player_position.y == 0)
        {
            Player_object.transform.position = new Vector3(0f, -11f, 0f);
        }
        else
        {
            Player_object.transform.position = new Vector3(GameManager.Instance.player_position.x, GameManager.Instance.player_position.y, 0f);
        }
        
    }
}
