using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private int _correctAnswers = 0;
    private int _questionsSeen = 0;

    public int CorrectAnswers => _correctAnswers;

    public int QuestionsSeen => _questionsSeen;

    public void IncrementCorrectAnswers()
    {
        _correctAnswers++;
    }

    public void IncrementQuestionsSeen()
    {
        _questionsSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt((float) _correctAnswers / _questionsSeen * 100);
    }
}