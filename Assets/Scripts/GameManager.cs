using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Quiz quiz;
    EndScreen endScreen;
    StartScreen startScreen;

    bool gameActive;
    
    void Awake()
    {
        quiz = FindObjectOfType<Quiz>();
        endScreen = FindObjectOfType<EndScreen>();
        startScreen = FindObjectOfType<StartScreen>();
    }

    void Start()
    {
        quiz.gameObject.SetActive(false);
        startScreen.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);

        gameActive = false;
    }

    void Update()
    {
        if (gameActive)
        {
            CheckGameComplete();
        }
    }

    void CheckGameComplete()
    {
        if (quiz.isComplete)
        {
            quiz.gameObject.SetActive(false);
            endScreen.gameObject.SetActive(true);
            endScreen.ShowFinalScore();
            gameActive = false;
        }
    }

    public void OnReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PlayGame()
    {
        quiz.gameObject.SetActive(true);
        startScreen.gameObject.SetActive(false);
        gameActive = true;
    }
}
