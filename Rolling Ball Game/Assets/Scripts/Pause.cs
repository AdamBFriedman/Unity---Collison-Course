using UnityEngine;

public class Pause : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // Pause game on space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
        }

        // Resume game on c
        if (Input.GetKeyDown(KeyCode.C))
        {
            Time.timeScale = 1;
        }

    }
}
