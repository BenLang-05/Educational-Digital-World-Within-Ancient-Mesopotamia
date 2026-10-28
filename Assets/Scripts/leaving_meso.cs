using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class leaving_meso : MonoBehaviour
{

    public GameObject loading;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            loading.SetActive(true);
            StartCoroutine(LoadAndSwitchBack(other.gameObject));
        }
    }

    private IEnumerator LoadAndSwitchBack(GameObject oldPlayer)
    {
        // Load Scene 1 additively
        AsyncOperation loadOp = SceneManager.LoadSceneAsync("Museum", LoadSceneMode.Additive);

        // Wait for it to finish
        while (!loadOp.isDone)
            yield return null;

        // Disable the Scene 2 player
        oldPlayer.SetActive(false);

        // Set Scene 1 as active
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Museum"));

        // Unload Scene 2
        SceneManager.UnloadSceneAsync("mesopotamia");
    }
}