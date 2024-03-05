using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace WEEK7
{

    public class Player : MonoBehaviour
    {
        private CharacterController CharacterController;

        [SerializeField]
        float speed = 5.0f;
        [SerializeField]
        float rotation = 5.0f;
        [SerializeField]
        float jump = 10f;

        public PlayerControls playerControls;

        private float mouseDeltaX = 0f;
        private float mouseDeltaY = 0f;
        private float cameraRotX = 0f;
        private int rotDir = 0;
        private bool grounded;

        private InputAction move;
        private InputAction look;
        private InputAction fire;

        Rigidbody rb;

        private void Awake()
        {
            PlayerControls PlayerControls = new PlayerControls();
            rb = GetComponent<Rigidbody>();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        /*private void OnEnable()
        {
            //Player controls enable
            move = playerControls.Player.Move;
            move.Enable();

            fire = playerControls.Player.Fire;
            fire.Enable();
            fire.performed += fire;

            look = playerControls.Player.Look;
            look.Enable();
        }

        private void OnDisable()
        {
            move.Disable();
            fire.Disable();
            look.Disable();
        }
        private void Update()
        {
            HandleHorizontalRotation();
            HandleVerticalRotation();

        }

        private void FixedUpdate()
        {
            grounded = IsGrounded();
            HandleMovement();
        }

        // Start is called before the first frame update
        void Start()
        {
            CharacterController = GetComponent<CharacterController>();
            lastMouseX = Input.mousePosition.x;
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
        }*/
    }
}
