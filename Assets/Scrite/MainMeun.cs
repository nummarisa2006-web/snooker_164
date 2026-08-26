<<<<<<< HEAD
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{ 
    public void StartGame()
    {
        SceneManager.LoadScene("Scenes01");
    }
=======
using UnityEngine;  
using UnityEngine.SceneManagement;

public class MainMeun : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Scene01");
    }   
>>>>>>> 7821a546efb99cd6076a3b1ca26621072fadcb9f

    public void ExitGame()
    {
        Application.Quit();
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 7821a546efb99cd6076a3b1ca26621072fadcb9f
