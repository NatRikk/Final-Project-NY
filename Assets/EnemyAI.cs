using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float speed = 5.0f;
    public float detectionRadius = 5.0f;
    public float attackRate = 2.0f;  // Attack every 2 seconds
    private float nextAttackTime = 0f;

    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) <= detectionRadius)
        {
            Vector3 direction = player.position - transform.position;
            transform.position += direction.normalized * speed * Time.deltaTime;

            if (Time.time >= nextAttackTime)
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    void Attack()
    {
        if (player.GetComponent<PlayerHealth>())
        {
            player.GetComponent<PlayerHealth>().TakeDamage(10);
        }
    }
}
