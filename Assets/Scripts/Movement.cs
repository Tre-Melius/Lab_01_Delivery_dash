using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    [SerializeField] float movespeed = 5f;
    [SerializeField] float rotationSpeed = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {    
    }
    //Rotation of the player object based on input

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed; // This gives a value between -1 and +1 for the x-axis
        float y = Input.GetAxis("Vertical") * Time.deltaTime * movespeed; // This gives a value between -1 and +1 for the y-axis
        Vector3 Move = new Vector3(x, y, 0f); // Create a new vector for movement
        //transform.Rotate(0f, 0f, 0.4f); 
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
          if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
        }
        transform.Translate(Move * movespeed*Time.deltaTime); // Move the player by adding the movement vector to the current position
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
            Debug.Log("Player collided with an obstacle!" + collision.gameObject.name);
            // Handle collision with obstacle here
            if (collision.gameObject.CompareTag("Respawn"))
            {
                // Handle collision with respawn object here
                Debug.Log("Player collided with a respawn object!");
            }
        
    }
   
}
