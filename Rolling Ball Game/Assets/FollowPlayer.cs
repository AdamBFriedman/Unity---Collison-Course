using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    // Vector3 (stores 3 floats)
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // lowercase transform refers to this GameObject
        // This will position the camera to the player and then add the offset so that it's behind and higher (following the player)
        transform.position = player.position + offset;
    }
}
