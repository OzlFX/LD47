using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject m_PauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        m_PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Escape"))
        {
            if (m_PauseMenu.activeSelf)
            {
                m_PauseMenu.SetActive(false);
            }
            else
            {
                m_PauseMenu.SetActive(true);
            }
        }
    }
}
