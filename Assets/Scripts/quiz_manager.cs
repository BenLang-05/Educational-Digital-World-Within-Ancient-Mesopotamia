using UnityEngine;
using System.Collections.Generic;


public class quiz_manager : MonoBehaviour
{

    public GameObject[] questions;
    public GameObject[] scores;
    public GameObject correct;
    public GameObject scorescrn;
    public GameObject thanks;
    public GameObject incorrect;
    private List<GameObject> selectedQuestions = new List<GameObject>();
    private int index = 0;
    private bool next = false;
    private bool done = false;

    private int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        pick5random();
        showQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        if(next && Input.GetKeyDown(KeyCode.Space))
        {
            correct.SetActive(false);
            incorrect.SetActive(false);
            next = false;
            pickNext();
        }

        else if (done && Input.GetKeyDown(KeyCode.Space))
        {
            scorescrn.SetActive(false);
            for(int i = 0; i < scores.Length; i++)
            {
                scores[i].SetActive(false);
            }
            thanks.SetActive(true);
        }
    }

    void pick5random() 
    {  
        List<GameObject> tempList = new List<GameObject>(questions);

        for(int i =0; i < tempList.Count; i++)
        { 
            int randInt = Random.Range(0, tempList.Count);
            GameObject temp = tempList[i];
            tempList[i] = tempList[randInt];
            tempList[randInt] = temp;
        }

        for(int i = 0; i <5; i++)
        {
            selectedQuestions.Add(tempList[i]);
        }
    }

    void showQuestion() 
    { 
        selectedQuestions[index].SetActive(true);
    }

    void pickNext()
    {
        selectedQuestions[index].SetActive(false);
        index++;

        if (index < selectedQuestions.Count)
        {
            showQuestion();
        }
        else
        {
            finished();
        }
    }

    public void answer(bool isCorrect)
    {
        selectedQuestions[index].SetActive(false);

        if (isCorrect)
        {
            score++;
            correct.SetActive(true);
        }
        else
        {
            incorrect.SetActive(true);
        }

        next = true;
    }
    
    
    void finished()
    {
        Debug.Log("Finished");
        scorescrn.SetActive(true);

        if (score == 0)
        {
            scores[0].SetActive(true);
        }
        else if (score == 1)
        {
            scores[1].SetActive(true);
        }
        else if (score == 2)
        {
            scores[2].SetActive(true);
        }
        else if (score == 3)
        {
            scores[3].SetActive(true);
        }
        else if (score == 4)
        {
            scores[4].SetActive(true);
        }
        else if (score == 5)
        {
            scores[5].SetActive(true);

        }


            done = true;
    }

}

