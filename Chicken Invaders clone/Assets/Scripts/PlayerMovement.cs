using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private float screenHorizontalLimit = 10.5f;
    private float screenVerticalLimit = 4.0f;
    [SerializeField] private InputActionAsset playerControl = null;
    private InputAction fire;
    [SerializeField] private GameObject bullet = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void Awake()
    {
        fire = playerControl.FindAction("Player/fire");
    }
    void Move()
    {
        Vector2 mouseScreenPosition = Mouse.current.position.ReadValue();
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        
        mouseWorldPosition.y = Mathf.Clamp(mouseWorldPosition.y, -screenVerticalLimit, screenVerticalLimit);
        mouseWorldPosition.x = Mathf.Clamp(mouseWorldPosition.x, -screenHorizontalLimit, screenHorizontalLimit);
        mouseWorldPosition.z = transform.position.z;
        transform.position = mouseWorldPosition;
    }
    void Fire()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
    void OnEnable()
    {
        fire.Enable();
        fire.performed += OnFireTriggered;
    }
    void OnDisable()
    {
        fire.Disable();
        fire.performed -= OnFireTriggered;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Debug.Log("Game over");
    }
    void OnFireTriggered(InputAction.CallbackContext context)
    {
        Fire();
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
