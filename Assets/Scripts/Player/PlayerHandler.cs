using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public float m_Speed = 5.0f;

    private Rigidbody2D m_Rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Verticle"));
        m_Rigidbody2D.AddForce(movement * m_Speed * Time.deltaTime);
    }
}
