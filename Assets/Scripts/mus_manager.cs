using UnityEngine;
using UnityEngine.SceneManagement;

public class mus_manager : MonoBehaviour
{
    public GameObject paused;
    public GameObject help;
    public GameObject quizReady;
    public GameObject loading;
    private movement playerMov;


    bool isPaused = false;

    void Start()
    {
        playerMov = FindObjectOfType<movement>();

        paused.SetActive(false);
        help.SetActive(false);
        quizReady.SetActive(false);
        loading.SetActive(false);
    }

    void Update()
    {
        // TOGGLE PAUSE MENU
        if (Input.GetKeyDown(KeyCode.Escape) && !quizReady.activeSelf)
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

        // QUIZ READY
        if (Input.GetKeyDown(KeyCode.K))
        {
            quizReady.SetActive(true);
        }

        if (quizReady.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                loading.SetActive(true);
                playerMov.DisableMovement();
                SceneManager.LoadScene("Quiz");
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                quizReady.SetActive(false);
                paused.SetActive(false);
            }
        }
    }
}