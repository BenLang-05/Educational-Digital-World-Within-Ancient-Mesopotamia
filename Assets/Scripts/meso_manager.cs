using UnityEngine;
using UnityEngine.SceneManagement;

public class meso_manager : MonoBehaviour
{
    public GameObject paused;
    public GameObject help;

    bool isPaused = false;

    void Start()
    {
        paused.SetActive(false);
        help.SetActive(false);
    }

    void Update()
    {
        // TOGGLE PAUSE MENU
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                // Open pause menu
                isPaused = true;
                paused.SetActive(true);
            }
            else
            {
                // Quit game
                Application.Quit();
            }
        }

        // PAUSE MENU CONTROLS
        if (isPaused)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                paused.SetActive(false);
                isPaused = false;
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                paused.SetActive(false);
                help.SetActive(true);
            }
        }

        // HELP SCREEN
        if (help.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                help.SetActive(false);
                paused.SetActive(true);
            }
        }

        
    }
}