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
        [SerializeField] private GameObject[] button;
        
        [Header("Texts")]
        [SerializeField] private TMP_Text questionText;
        [SerializeField] private TMP_Text[] answerText;
        [SerializeField] private float writeSpeed;
        
        [Header("Question")] 
        [SerializeField] private string sentences;
        #endregion

        protected static bool PlayerTriggered { get; set; }
        
        private void Update()
        {
            NpcPanelController();

            if (questionText.text == sentences)
            {
                button[0].SetActive(PlayerTriggered);
                button[1].SetActive(PlayerTriggered);
            }
        }

        #region DialogueRegion

        private IEnumerator Dialogue()
        {
            foreach (char letter in sentences.ToCharArray())
            {
                questionText.text += letter;
                yield return new WaitForSeconds(writeSpeed);
            }
        }
        
        protected void StartDialogue()
        {
            questionText.text = "";
            StartCoroutine(Dialogue());
        }
        #endregion

        #region Panel&ImageController
        private void NpcPanelController()
        {
            panel.SetActive(PlayerTriggered);
        }
        #endregion
    }
}

