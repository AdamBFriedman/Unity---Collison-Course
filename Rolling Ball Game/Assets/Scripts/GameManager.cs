using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Changing States in our Game.  Add "public" to make this function public
    public void EndGame ()
    {
        Debug.Log("Game over!");
    }
}
