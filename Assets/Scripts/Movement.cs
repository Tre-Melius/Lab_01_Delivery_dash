using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    [SerializeField] public float steerSpeed = 300f;
    [SerializeField] public float moveSpeed = 5f;

    public Rigidbody2D _rb;

    void Start()
    {
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

        float moveAmount = move * moveSpeed * Time.deltaTime;
        float steerAmount = steer * steerSpeed * Time.deltaTime;
        // moveInput.x = steering (left/right stick or A/D)
        // moveInput.y = forward (up/down stick or W/S)

        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}   