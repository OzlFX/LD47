using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public float m_Speed = 5.0f;

    private Rigidbody2D m_Rigidbody2D;

    Vector2 m_Movement;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        m_Movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        m_Rigidbody2D.MovePosition(m_Rigidbody2D.position + m_Movement * m_Speed * Time.fixedDeltaTime);
    }
}
