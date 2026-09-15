using UnityEngine;

public class Collision : MonoBehaviour
{
 void OnCollisionEnter2d(Collision2D collision)
 {
    Debug.Log("You have entered the Realm of doom, death, and destruction");
 
 }
 void OnTrifferEnter2d(Collider2D collision)
 {
    Debug.Log("You have made it through the realm");
 }
}
