using UnityEngine;

public class Capsule : MonoBehaviour
{
    private CharacterController CharacterController;

    [SerializeField]
    float speed = 5.0f;
    [SerializeField]
    float rotation = 5.0f;

    private float lastMouseX = 0f;
    private float mouseDeltaX = 0f;
    private int rotDir = 0;

    // Start is called before the first frame update
    void Start()
    {
        CharacterController = GetComponent<CharacterController>();
        lastMouseX = Input.mousePosition.x;
    }

    private void Update()
    {
        HandleMovement();
        HandleRotation();

    }

    void HandleMovement()
    {
        Vector3 input = (Input.GetAxis("Horizontal") * transform.right) + (transform.forward * Input.GetAxis("vertical"));
        CharacterController.Move(input * speed * Time.deltaTime);
    }

    void HandleRotation()
    {
        mouseDeltaX = Input.mousePosition.x - lastMouseX;

        if (mouseDeltaX !=0)
        {
            rotDir = mouseDeltaX > 0 ? 1 : -1;
            lastMouseX = Input.mousePosition.x;

            transform.eulerAngles += new Vector3(0, rotation * Time.deltaTime * rotDir, 0);
        }
    }
}
