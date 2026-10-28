using UnityEngine;

public class button_manager : MonoBehaviour
{
    public bool isCorrect; // Set this in the Inspector

    public void OnClick()
    {
        Debug.Log("Clicked");
        FindObjectOfType<quiz_manager>().answer(isCorrect);
    }
}