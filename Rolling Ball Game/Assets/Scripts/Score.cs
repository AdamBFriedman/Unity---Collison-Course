using UnityEngine;
// Bring in for UI
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Reference movement of our player
    public Transform player;

    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        // Update text with the players movement
        scoreText.text = player.position.z.ToString("0");
    }
}
