using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionsSeen = 0;
    
    public int GetCorrectAnswers()
    {
        return correctAnswers;
    }

    public int GetQuestionsSeen()
    {
        return questionsSeen;
    }

    public void IncrementCorrectAnswers()
    {
        correctAnswers++;
    }

    public void IncrementQuestionsSeen()
    {
        questionsSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt((float)correctAnswers / questionsSeen * 100);
    }
}
