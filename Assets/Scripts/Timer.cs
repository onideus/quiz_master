using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float timeToCompleteQuestion = 30f;
    [SerializeField] private float timeToReviewAnswer = 10f;

    public bool loadNextQuestion;
    public float fillFraction;
    
    public bool isAnsweringQuestion;
    private float _timeRemaining;
    
    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        _timeRemaining = 0;
    }
    
    void UpdateTimer()
    {
        _timeRemaining -= Time.deltaTime;

        if (isAnsweringQuestion)
        {
            if (_timeRemaining > 0)
            {
                fillFraction = _timeRemaining / timeToCompleteQuestion;
            }
            else
            {
                isAnsweringQuestion = false;
                _timeRemaining = timeToReviewAnswer;
            }
        }
        else
        {
            if (_timeRemaining > 0)
            {
                fillFraction = _timeRemaining / timeToReviewAnswer;
            }
            else
            {
                isAnsweringQuestion = true;
                _timeRemaining = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
    }
}
