using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace GameFolders.Scripts.Abstracts.Controllers
{
    public abstract class Npc : MonoBehaviour
    {
        #region Npc Options
        [Header("NPC Panel")]
        [SerializeField] private GameObject panel;
        [SerializeField] private GameObject npcImage;
        [SerializeField] private GameObject[] button;
        
        [Header("Texts")]
        [SerializeField] private TMP_Text questionText;
        [SerializeField] private TMP_Text[] answerText;
        [SerializeField] private float writeSpeed;
        
        [Header("Question")] 
        [SerializeField] private string sentences;
        #endregion
        
        private static bool PlayerTriggered { get; set; }

        private void Start()
        {
            answerText[0].text = "Cevap A";
            answerText[1].text = "Cevap B";
        }

        private void Update()
        {
            NpcPanelController();

            if (questionText.text == sentences)
            {
                button[0].SetActive(PlayerTriggered);
                button[1].SetActive(PlayerTriggered);
            }
        }

        #region TriggerRegion
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Player"))
            {
                PlayerTriggered = true;
                StartDialogue();
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                PlayerTriggered = false;
            }
        }
        #endregion
        
        #region DialogueRegion

        private IEnumerator Dialogue()
        {
            foreach (char letter in sentences.ToCharArray())
            {
                questionText.text += letter;
                yield return new WaitForSeconds(writeSpeed);
            }
        }
        
        private void StartDialogue()
        {
            questionText.text = "";
            StartCoroutine(Dialogue());
        }
        #endregion

        #region Panel&ImageController
        private void NpcPanelController()
        {
            panel.SetActive(PlayerTriggered);
            npcImage.SetActive(PlayerTriggered);
        }
        #endregion
    }
}

