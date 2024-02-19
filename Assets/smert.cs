using UnityEngine;

public class smert : MonoBehaviour
{
    // The position where the object should teleport to after collision
    private Vector3 teleportPosition;

    // The object's initial position before any rendering occurs
    private Vector3 initialPosition;

    // Reference to the Rigidbody component
    private Rigidbody rb;

    void Start()
    {
        // Store the object's initial position
        initialPosition = transform.position;

        // Get the reference to the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    // Function called when another collider enters this object's collider
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object is tagged as "Floor"
        if (collision.gameObject.CompareTag("lava"))
        {
            // Teleport the object to the initial position
            Teleport();

            // Reset the object's velocity to zero
            ResetVelocity();
        }
    }

    // Function to teleport the object to its initial position
    void Teleport()
    {
        // Teleport the object to the initial position
        transform.position = initialPosition;
    }

    // Function to reset the object's velocity to zero
    void ResetVelocity()
    {
        // Set the Rigidbody's velocity to zero
        rb.velocity = Vector3.zero;
    }
}
