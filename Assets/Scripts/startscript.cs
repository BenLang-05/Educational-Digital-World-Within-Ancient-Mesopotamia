using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class startscript : MonoBehaviour
{
    public GameObject startobj;
    public GameObject loading;
    public GameObject help;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startobj.SetActive(true);
        loading.SetActive(false);
        help.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (startobj.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                startobj.SetActive(false);
                help.SetActive(true);
            }

        }
        else if (help.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                help.SetActive(false);
                loading.SetActive(true);
                SceneManager.LoadScene("Museum");
            }
        }

    }

}
