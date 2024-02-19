using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    // Define a tag to identify objects that can cause death
    public string collisionTag = "lava";

    // Function called when another collider enters this object's trigger collider
    void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider has the specified tag
        if (other.CompareTag(collisionTag))
        {
            // Destroy this object
            Destroy(gameObject);
        }
    }
}


