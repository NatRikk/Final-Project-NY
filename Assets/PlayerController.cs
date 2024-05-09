using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 7.0f;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    public class PlayerHealth : MonoBehaviour
    {
        public int health = 100;

        void Update()
        {
            if (health <= 0)
            {
                Die();
            }
        }

        void Die()
        {
            Debug.Log("Player Died - Restarting Game");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void TakeDamage(int damage)
        {
            health -= damage;
        }
    }
}
