﻿using UnityEngine;
// Add this to change scenes or reload scenes
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Create boolean to check if game ended
    bool gameHasEnded = false;

    // Create restartDelay variable
    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }

    // Changing States in our Game.  Add "public" to make this function public
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game over!");
            // Restart Game
            Invoke("Restart", restartDelay);
        }
    }

    // Create Restart function
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
