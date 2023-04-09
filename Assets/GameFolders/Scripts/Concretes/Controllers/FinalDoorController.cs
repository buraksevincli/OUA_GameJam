using System;
using GameFolders.Scripts.Concretes.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalDoorController : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (KeyManager.Instance.key1bool &&
            KeyManager.Instance.key2bool &&
            KeyManager.Instance.key3bool &&
            KeyManager.Instance.key4bool &&
            KeyManager.Instance.key5bool &&
            KeyManager.Instance.key6bool &&
            KeyManager.Instance.key7bool )
        {
            SceneManager.LoadScene("AcademyPalace");
        }
        else
        {
            panel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        panel.SetActive(false);
    }
}
