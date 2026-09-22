using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    [SerializeField] public float steerSpeed = 300f;
    [SerializeField] public float moveSpeed = 5f;

    public Vector2 moveInput;
    public Rigidbody2D _rb;

    void Start()
    {
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Update()
    {
        // moveInput.x = steering (left/right stick or A/D)
        // moveInput.y = forward (up/down stick or W/S)

        transform.Rotate(0, 0, moveInput.x * steerSpeed * Time.deltaTime);
        transform.Translate(transform.up * (moveInput.y * moveSpeed * Time.deltaTime));
    }
}   