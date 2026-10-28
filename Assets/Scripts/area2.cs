using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class area2 : MonoBehaviour
{
    public GameObject textI;

    private bool inside = false;


    private void Start()
    {

    }

    private void Update()
    {

        if (inside)
        {
            textI.SetActive(true);
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
            textI.SetActive(false);
            print("exitted box");

        }
    }

}

