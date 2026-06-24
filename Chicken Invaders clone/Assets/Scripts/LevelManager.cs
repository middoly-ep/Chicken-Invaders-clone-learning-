using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject player;
    private int enemyCount = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void OnEnemyDie()
    {
        enemyCount--;
        Instantiate(enemy, new Vector2(player.transform.position.x, player.transform.position.y + 5), player.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
