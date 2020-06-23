using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Create boolean to check if game ended
    bool gameHasEnded = false;

    // Changing States in our Game.  Add "public" to make this function public
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game over!");
            // Restart Game
        }
    }
}
