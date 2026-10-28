using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class area1: MonoBehaviour
{
    public GameObject textT;
    public GameObject textE;
    public GameObject textI;

    public GameObject canvas;


    private bool inside = false;


    private void Start()
    {

    }

    private void Update()
    {

        if (inside)
        {
            if (canvas.activeSelf == false)
            {
                textT.SetActive(true);
                textI.SetActive(true);
                textE.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                textI.SetActive(false);
                canvas.SetActive(true);
                textT.SetActive(false);
                textE.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                canvas.SetActive(false);
                textT.SetActive(true);
                textE.SetActive(false);
                textI.SetActive(true);

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
            canvas.SetActive(false);
            textT.SetActive(false);
            textE.SetActive(false);
            textI.SetActive(false);
            print("exitted box");

        }
    }

}

