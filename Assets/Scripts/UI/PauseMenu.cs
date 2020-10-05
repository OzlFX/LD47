using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject m_PauseMenu;
    public static bool m_Paused = false;

    // Start is called before the first frame update
    void Start()
    {
        m_PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (m_Paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        m_PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        m_Paused = false;
    }

    void Pause()
    {
        m_PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        m_Paused = true;
    }
}
