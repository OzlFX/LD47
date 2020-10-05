using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Get next scene in build queue
    }

    public void Quit()
    {
        Application.Quit(); //Quit Application
    }
}
