using GameFolders.Scripts.Abstracts.Controllers;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class NpcController : Npc
    {
        [SerializeField] private GameObject npcImage;
        
        #region TriggerRegion
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Player"))
            {
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
        }
        #endregion
    }
}

