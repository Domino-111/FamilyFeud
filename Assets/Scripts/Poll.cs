using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class Poll : MonoBehaviour
{
    public TMP_Text displayQuestion;

    public DataManager data;

    public int n = 0;

    public TMP_InputField response;

    public List<string> SwearFilter;

    public GameObject invalidAnswer;

    private void Awake()
    {
        displayQuestion.text = data.myQuestions[0].question;

        invalidAnswer.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!SwearFilter.Contains(response.text.ToLower()))
            {
                data.myQuestions[n].responses.Add(response.text);
                data.SavedGame();
            }

            else
            {
                invalidAnswer.SetActive(true);
                Invoke("InvalidAnswer", 4f);
            }
        }
    }

    public void NextQuestion()
    {
        n++;

        if (n > 9)
        {
            n = 0;
        }

        displayQuestion.text = data.myQuestions[n].question;
        response.text = "";
    }

    public void PreviousQuestion()
    {
        n--;

        if (n < 0)
        {
            n = 9;
        }

        displayQuestion.text = data.myQuestions[n].question;
        response.text = "";
    }

    public void InvalidAnswer()
    {
        invalidAnswer.SetActive(false);
    }
}
