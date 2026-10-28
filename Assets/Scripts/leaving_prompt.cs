using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class leaving_prompt : MonoBehaviour
{
    public GameObject congrats;

    private bool inside = false;


    private void Start()
    {

    }

    private void Update()
    {

        if (inside)
        {
            congrats.SetActive(true);
            if(Input.GetKeyDown(KeyCode.Space))
            {
                congrats.SetActive(false);
                inside = false;
            }
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inside = true;
            print("inside box");

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inside = false;
            congrats.SetActive(false);
            print("exitted box");

        }
    }
}