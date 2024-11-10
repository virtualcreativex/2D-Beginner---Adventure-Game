using UnityEngine;

public class HealthCollectiblex : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Object that entered the trigger: " + other);
    }
    
}
