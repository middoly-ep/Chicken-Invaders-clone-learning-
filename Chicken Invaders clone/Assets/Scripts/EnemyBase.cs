using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField] protected float hp = 0;
    [SerializeField] protected float moveSpeed = 5.0f;

    public void TakeDamage(float bullet_damage)
    {
        this.hp -= bullet_damage;
        if (this.hp <= 0) Destroy(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(ScreenBoundaries.GetTopRight().x);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPosition = transform.position;
        if (currentPosition.x >= ScreenBoundaries.GetTopRight().x)
        {
            currentPosition.x = ScreenBoundaries.GetBottomLeft().x;
        }
        
        currentPosition.x += moveSpeed * Time.deltaTime;
        transform.position = currentPosition;
    }
}
