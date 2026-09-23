using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    [SerializeField] public float steerSpeed = 300f;
    [SerializeField] public float currentSpeed = 5f;
    [SerializeField] public float boostSpeed = 10f;
    [SerializeField] public float regularSpeed = 5f;

    public Rigidbody2D _rb;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boost"));
        {
            currentSpeed = boostSpeed;
            Destroy(collision.gameObject);
        }
    }    

    void OnCollisionEnter2D(Collision2D collision)
    {
        currentSpeed = regularSpeed;
    }

    void Update()
    {
        float steer= 0;
        float move= 0;
        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }
        else if(Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }

         else if(Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }

        float moveAmount = move * currentSpeed * Time.deltaTime;
        float steerAmount = steer * steerSpeed * Time.deltaTime;
        // moveInput.x = steering (left/right stick or A/D)
        // moveInput.y = forward (up/down stick or W/S)

        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}   