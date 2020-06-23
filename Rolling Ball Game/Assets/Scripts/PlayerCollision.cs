using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Create PlayerMovement reference from script
    public PlayerMovement movement;

    // Create a collision function
    private void OnCollisionEnter(Collision collisionInfo)
    {
        //// Check collisionInfo object for name of Obstacle
        //if (collisionInfo.collider.name == "Obstacle")
        //{
        //    Debug.Log("We hit an obstacle!");
        //}

        // Check collisionInfo object for tag named Obstacle
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // Disable movement
            movement.enabled = false;
            // Find Object
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
