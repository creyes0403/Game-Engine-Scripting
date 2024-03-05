using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControlsWeek7 : MonoBehaviour
{
    InputAction moveAction;
    InputAction jumpAction;
    InputAction lookAction;

    PlayerControlsMapping mapping;

    private float mouseDeltaX = 0f;
    private float mouseDeltaY = 0f;
    private float cameraRotX = 0f;
    private int rotDir = 0;
    private bool grounded;

    Rigidbody rb;

    [SerializeField] float jumpForce = 5f;

    const float SPEED = 5.5f;

    public void Awake()
    {
        mapping = new PlayerControlsMapping();
        rb = GetComponent<Rigidbody>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        
    }

    private void OnEnable()
    {
        moveAction = mapping.Player.Move;
        moveAction.Enable();

        jumpAction = mapping.Player.Jump;
        jumpAction.Enable();
        jumpAction.performed += Jump;
    }

    private void OnDisable()
    {
        moveAction.Disable();
        jumpAction.Disable();

        jumpAction.performed -= Jump;
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void Update()
    {
        //if (IsGrounded() == false) return;

        /*returns vector2 w/values of the format (x,y) where
        xrepresents out input from A & D
        Y represents our input from W & S
        On a ragne from -1 to +1*/

        Vector2 input = moveAction.ReadValue<Vector2>();
       input *= SPEED;
        Debug.Log(input);
        /*transform.position += new Vector3 (transform.position.x + input.x,
                                           transform.position.y,
                                           transform.position.z + input.y);*/
        rb.velocity = new Vector3(input.x, rb.velocity.y, input.y);
    }

    bool IsGrounded()
    {
        int layerMask = 1 << 3;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up * -1), out hit, 1.1f, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up * -1) * hit.distance, Color.yellow);
            return true;
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up * -1) * 100, Color.white);
            return false;
        }
    }



    void Jump(InputAction.CallbackContext context)
    {
        if (IsGrounded() == false) return;
        rb.AddForce(Vector3.up * jumpForce);
    }


}
