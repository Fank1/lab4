using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private InputAction iMove;
    private Rigidbody rb;
    public float speed = 3f;

    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
    }
    
    private void OnEnable()
    {
        iMove = InputSystem.actions.FindAction("Player/Move");
        iMove.performed      += HandleMovement;
        iMove.Enable();
    }
    
    private void OnDisable()
    {
        iMove.performed  -= HandleMovement;
        iMove.Disable();
    }

    private void HandleMovement(InputAction.CallbackContext ctx)
    {
        
    }
    
    void Update()
    {
        Vector2 playerMovement = iMove.ReadValue<Vector2>();
        rb.AddForce(new Vector3(playerMovement.x * speed, 0, playerMovement.y * speed));
    }
}

