using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    InputAction moveAction;
    Rigidbody rb;
        
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {

        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        rb.linearVelocity = new Vector3(moveValue.y, rb.linearVelocity.y, -moveValue.x);


    }
}
