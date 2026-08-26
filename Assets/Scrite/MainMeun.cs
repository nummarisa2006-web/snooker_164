using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{ 
    public void StartGame()
    {
        SceneManager.LoadScene("Scenes01");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}