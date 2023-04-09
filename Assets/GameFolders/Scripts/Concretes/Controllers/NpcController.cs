using GameFolders.Scripts.Abstracts.Controllers;
using GameFolders.Scripts.Concretes.Managers;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class NpcController : Npc
    {
        [SerializeField] private GameObject npcImage;
        [SerializeField] GameObject questionController;

        #region TriggerRegion
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Player"))
            {
                GameManager.Instance.PlayerAnswer = true;
                PlayerTriggered = true;
                npcImage.SetActive(true);
                StartDialogue();
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                PlayerTriggered = false;
                npcImage.SetActive(false);
            }
            questionController.GetComponent<ButtonManagement>().Question_controller = false;
        }
        #endregion
    }
}

