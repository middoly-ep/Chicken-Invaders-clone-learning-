using UnityEngine;

public class BulletBase : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float damage = 2.0f;
    private Rigidbody2D rb;
    private float screenVerticalLimit = 4.0f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            EnemyBase enemy = collision.GetComponent<EnemyBase>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }
        Destroy(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocityY = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= screenVerticalLimit) Destroy(gameObject);
    }
}
