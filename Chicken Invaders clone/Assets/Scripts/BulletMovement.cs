using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    private Rigidbody2D rb;
    private float screenVerticalLimit = 4.0f;
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
