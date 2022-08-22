using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    [Header("Questions")]
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] List<QuestionSO> questions = new List<QuestionSO>();
    QuestionSO currentQuestion;

    [Header("Answers")]
    [SerializeField] GameObject[] answerButtons;
    int correctAnswerIndex;
    bool hasAnsweredEarly = true;

    [Header("Button Colors")]
    [SerializeField] Sprite defaultAnswerSprite;
    [SerializeField] Sprite correctAnswerSprite;

    [Header("Timer")]
    [SerializeField] Image timerImage;
    [SerializeField] Timer timer;

    [Header("Scoring")]
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] Scorekeeper scoreKeeper;

    [Header("Progress Bar")]
    [SerializeField] Slider progressBar;

    public bool isComplete;
  
    //constructor
    void Start()
    {
        hasAnsweredEarly = false;
        isComplete = false;
        progressBar.maxValue = questions.Count;
        progressBar.value = 0;

        Update();
    }

    void Update()
    {
        timerImage.fillAmount = timer.fillFraction;
        
        if (timer.loadNextQuestion)
        {
            if (progressBar.value >= progressBar.maxValue)
            {
                isComplete = true;
            }
            else
            {
                GetNextQuestion();
                timer.loadNextQuestion = false;
            }
            
        }
        else if (!hasAnsweredEarly && !timer.isAnsweringQuestion)
        {
            DisplayAnswer(-1);
            SetButtonState(false);
            Debug.Log("ugh");
        } 
    }

    //tells the user if their answer is correct when a choice is selected
    public void OnAnswerSelected(int index)
    {
        DisplayAnswer(index);
        SetButtonState(false);
        timer.CancelTimer();
        hasAnsweredEarly = true;
        scoreText.text = "Score: " + scoreKeeper.CalculateScore() + "%";
    }

    void DisplayAnswer(int index)
    {
        Image buttonImage = answerButtons[correctAnswerIndex].GetComponent<Image>();
        buttonImage.sprite = correctAnswerSprite;

        if (index == correctAnswerIndex)
        {
            questionText.text = currentQuestion.GetQuestion() + "\nCorrect!";
            scoreKeeper.IncrementCorrectAnswers();
        }
        else
        {
            questionText.text = currentQuestion.GetQuestion() + "\nIncorrect! The correct answer is shown below.";
        }

    }

    void GetRandomQuestion()
    {
        int randIndex = Random.Range(0, questions.Count);
        currentQuestion = questions[randIndex];
        if (questions.Contains(currentQuestion)) 
        {
            questions.Remove(currentQuestion);
        }
    }

    //displays current question on canvas
    void DisplayQuestion()
    {
        questionText.text = currentQuestion.GetQuestion();
        correctAnswerIndex = currentQuestion.GetCorrectAnswerIndex();

        for (int i = 0;i < answerButtons.Length;i ++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = currentQuestion.GetAnswer(i);
        }
    }

    //enables or disables all answer buttons
    void SetButtonState(bool state)
    {
        for(int i = 0;i < answerButtons.Length;i ++)
        {
            Button button = answerButtons[i].GetComponent<Button>();
            button.interactable = state;
        }
    }

    //resets answer button sprites
    void SetDefaultButtonSprites()
    {
        for(int i = 0;i < answerButtons.Length;i ++)
        {
            Image buttonImage = answerButtons[i].GetComponent<Image>();
            buttonImage.sprite = defaultAnswerSprite;
        }
    }
   
    //sets up next question for user on campus
    void GetNextQuestion()
    {
        if (questions.Count > 0)
        {
            //sprites and visuals
            SetButtonState(true);
            SetDefaultButtonSprites();

            //question setting
            GetRandomQuestion();
            DisplayQuestion();

            timer.isAnsweringQuestion = true;
            scoreKeeper.IncrementQuestionsSeen();
            progressBar.value ++;
        }
    }
}
