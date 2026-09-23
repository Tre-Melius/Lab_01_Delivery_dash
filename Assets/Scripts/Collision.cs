using UnityEngine;

public class Delivery : MonoBehaviour
{
 void OnTriggerEnter2d(Collider2D collision)
 {
    if(collision.CompareTag("Package"))
    {
      Debug.Log("Picked up package");
    }

    if(collision.CompareTag("Customer"))
    {
         Debug.Log("Delivered the package");
    }
 }
}
