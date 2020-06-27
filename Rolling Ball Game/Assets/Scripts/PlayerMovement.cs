using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigibody component called "rb"
    public Rigidbody rb;

    // Create variables
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Create spin variable
    public float spinSpeed;

    // Update is called once per frame.
    //void Update()
    //{
    //    // AddForce(x, y, z)
    //    //rb.AddForce(0, 0, 200);

    //    // AddForce(x, y, z) with Time.deltaTime(amount of seconds since the computer drew the last frame)
    //    rb.AddForce(0, 0, 2000 * Time.deltaTime);
    //}

    // We use FixedUpdate() when calculating physics
    void FixedUpdate()
    {
        // AddForce(x, y, z)
        //rb.AddForce(0, 0, 200);

        //// AddForce(x, y, z) with Time.deltaTime(amount of seconds since the computer drew the last frame)
        //rb.AddForce(0, 0, 2000 * Time.deltaTime);

        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Input.GetKey()
        // Set left key
        //if (Input.GetKey("d"))
        //{
        //    rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        //}

        //// Set right key
        //if (Input.GetKey("a"))
        //{
        //    rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        //}
        spinSpeed = (spinSpeed + 10);
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);

        // Changing player movement by adding ForceMode.VelocityChange
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Set right key
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // End Game if Player fell off map
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
