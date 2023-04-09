using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.tag)
        {
            case "Start":
                SceneManager.LoadScene("Story");
                break;
            case "Credits":
                SceneManager.LoadScene("Credits");
                break;
            case "Exit":
                Application.Quit();
                break;
        }
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
