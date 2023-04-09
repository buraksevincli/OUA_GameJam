using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryManager : MonoBehaviour
{
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private string[] dialogueSentences;
    [SerializeField] private GameObject continueButton;

    [SerializeField] private float writeSpeed;

    private int _story;
        
    private void Start()
    {
        StartCoroutine(DialogueMethod());
    }

    private void Update()
    {
        if (dialogueText.text == dialogueSentences[_story])
        {
            continueButton.SetActive(true);
        }
    }

    IEnumerator DialogueMethod()
    {
        foreach (char letter in dialogueSentences[_story].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(writeSpeed);
        }
    }

    public void NextSentences()
    {
        continueButton.SetActive(false);
            
        if (_story < dialogueSentences.Length -1)
        {
            _story++;
            dialogueText.text = "";
            StartCoroutine(DialogueMethod());
        }
    }

    public void NextScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
