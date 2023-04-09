using GameFolders.Scripts.Concretes.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "home1":
                SceneManager.LoadScene("Home1");
                GameManager.Instance.player_position = new Vector3(GameManager.Instance.home1_vector.x, GameManager.Instance.home1_vector.y, 0f);
                break;

            case "home2":
                SceneManager.LoadScene("Home2");
                GameManager.Instance.player_position = new Vector3(GameManager.Instance.home2_vector.x, GameManager.Instance.home2_vector.y, 0f);
                break;

            case "home3":
                SceneManager.LoadScene("Home3");
                GameManager.Instance.player_position = new Vector3(GameManager.Instance.home3_vector.x, GameManager.Instance.home3_vector.y, 0f);
                break;

            case "home4":
                SceneManager.LoadScene("Home4");
                GameManager.Instance.player_position = new Vector3(GameManager.Instance.home4_vector.x, GameManager.Instance.home4_vector.y, 0f);
                break;

            case "home5":
                SceneManager.LoadScene("Home5");
                GameManager.Instance.player_position = new Vector3(GameManager.Instance.home5_vector.x, GameManager.Instance.home5_vector.y, 0f);
                break;

            case "MainBuilding":
                SceneManager.LoadScene("Main Building");
                GameManager.Instance.player_position = new Vector3(GameManager.Instance.MainBuilding_vector.x, GameManager.Instance.MainBuilding_vector.y, 0f);
                break;

            case "Storage":
                SceneManager.LoadScene("Storage");
                GameManager.Instance.player_position = new Vector3(GameManager.Instance.storage_vector.x, GameManager.Instance.storage_vector.y, 0f);
                break;
            
            case "home3_basement":
                SceneManager.LoadScene("Home3 Basement");
                break;

            case "main":
                SceneManager.LoadScene("Game");
                break;
        }
        
    }
}
