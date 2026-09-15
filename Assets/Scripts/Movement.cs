using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    [SerializeField]float steerMove = 0.5f;
    [SerializeField] float steerSpeed = 0.05f;

    private InputActionMap m_Map;
    private InputAction m_Move;
    private InputAction m_Turn;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Attempt to add controller support
    void Awake()
    {
         m_Map = new InputActionMap("Player");


        m_Map = m_Map.AddAction("Move", InputActionType.Value);
         
    }
    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0f, 0f, 0.4f); 
        

        float steer = 0f;
        float move = 0f;

        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }

        float moveAmount = steer * steerSpeed * Time.deltaTime;
        float steerAmount = move * steerMove * Time.deltaTime;
            
        transform.Rotate(0, 0, moveAmount);
        transform.Translate(0, steerAmount, 0);
        
    }
}
