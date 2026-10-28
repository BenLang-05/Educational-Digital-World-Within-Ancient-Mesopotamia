using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class leaving_mus : MonoBehaviour
{

    public GameObject loading;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            loading.SetActive(true);
            StartCoroutine(LoadAndSwitch(other.gameObject));
        }
    }

    private IEnumerator LoadAndSwitch(GameObject oldPlayer)
    {
        // Load Scene 2 additively
        AsyncOperation loadOp = SceneManager.LoadSceneAsync("mesopotamia", LoadSceneMode.Additive);

        // Wait for it to finish
        while (!loadOp.isDone)
            yield return null;

        // Disable the old player so it can't hit the trigger again
        oldPlayer.SetActive(false);

        // Set Scene 2 as active
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("mesopotamia"));

        // Unload Scene 1
        SceneManager.UnloadSceneAsync("Museum");
    }
}