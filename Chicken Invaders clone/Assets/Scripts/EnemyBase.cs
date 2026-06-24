using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField] private EnemyNhiSO enemyNhiSO;
    [SerializeField] private LevelManager levelManager;
    private int hp;
    private float moveSpeed;
    public void TakeDamage(int bullet_damage)
    {
        this.hp -= bullet_damage;
        if (this.hp <= 0){
            levelManager.OnEnemyDie();
            Destroy(gameObject);
        }
    }
    void OnEnable()
    {
        hp = enemyNhiSO.HP;
        moveSpeed = enemyNhiSO.MoveSpeed;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        levelManager = Object.FindAnyObjectByType<LevelManager>();
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
