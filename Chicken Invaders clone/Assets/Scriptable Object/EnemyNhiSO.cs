using UnityEngine;

[CreateAssetMenu(fileName = "EnemyNhiSO", menuName = "Scriptable Objects/EnemyNhiSO")]
public class EnemyNhiSO : ScriptableObject
{
    [SerializeField] private int hp = 4;
    [SerializeField] private float moveSpeed = 5.0f;
    public int HP
    {
        get {return hp;}
    }
    public float MoveSpeed
    {
        get {return moveSpeed;}
    }
}
