using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private float screenHorizontalLimit = 10.5f;
    private float screenVerticalLimit = 4.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseScreenPosition = Mouse.current.position.ReadValue();
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        
        mouseWorldPosition.y = Mathf.Clamp(mouseWorldPosition.y, -screenVerticalLimit, screenVerticalLimit);
        mouseWorldPosition.x = Mathf.Clamp(mouseWorldPosition.x, -screenHorizontalLimit, screenHorizontalLimit);
        mouseWorldPosition.z = transform.position.z;
        transform.position = mouseWorldPosition;
        
    }
}
