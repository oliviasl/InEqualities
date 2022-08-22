using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    
    [SerializeField] float timeToCompleteQuestion = 15f;
    [SerializeField] float timeToShowCorrectAnswer = 3f;
    
    float timerValue;
    
    public float fillFraction;
    public bool loadNextQuestion;
    public bool isAnsweringQuestion;

    void Start()
    {
        isAnsweringQuestion = false;
        loadNextQuestion = true;
        timerValue = timeToCompleteQuestion;
        fillFraction = 1;
    }

    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnsweringQuestion)
        {
            if (timerValue > 0 )
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }
            else
            {
                timerValue = timeToShowCorrectAnswer;
                isAnsweringQuestion = false;
            }
        }
        else
        {
            if (timerValue > 0 )
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            else
            {
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
                isAnsweringQuestion = true;
            }
        }
        
    }
}
