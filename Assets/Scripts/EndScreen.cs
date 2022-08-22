using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    Scorekeeper scoreKeeper;
    
    void Awake()
    {
        scoreKeeper = FindObjectOfType<Scorekeeper>();
    }

    public void ShowFinalScore()
    {
        finalScoreText.text = "You got a score of " + 
                                scoreKeeper.CalculateScore() + "%!";
    }
}
