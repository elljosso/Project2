using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Snelheid van de speler
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Zet constraints om rotatie te voorkomen
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
    }

    // Update wordt elke frame aangeroepen
    void Update()
    {
        // Input van de toetsen z, s, q, d
        float horizontalInput = Input.GetAxis("Horizontal"); // Dit wordt q (-1) of d (1)
        float verticalInput = Input.GetAxis("Vertical"); // Dit wordt s (-1) of z (1)


        // Bereken de bewegingsrichting
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Als er input is, beweeg de speler
        if (moveDirection != Vector3.zero)
        {
            // Bereken de nieuwe positie
            Vector3 newPosition = transform.position + transform.TransformDirection(moveDirection) * moveSpeed * Time.deltaTime;

            // Verplaats de speler naar de nieuwe positie
            rb.MovePosition(newPosition);
        }
    }
}