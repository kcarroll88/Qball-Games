using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathGame : MonoBehaviour
{
    [SerializeField] int minNumber;
    [SerializeField] int maxNumber;
    [SerializeField] Text mathProblemText;
    [SerializeField] Text answerText;

    [SerializeField] bool newQuestion = true;
    [SerializeField] bool answerCorrect;

    // Start is called before the first frame update
    void Start()
    {
        newQuestion = true;
    }

    // Update is called once per frame
    void Update()
    {
        CreateMathProblem();
    }

    public void CreateMathProblem()
    {
        if (newQuestion)
        {
            // Make random numbers between min and max range
            var number1 = UnityEngine.Random.Range(minNumber, maxNumber);
            var number2 = UnityEngine.Random.Range(minNumber, maxNumber);

            // Set Problem
            var mathProblem = number1 + " + " + number2;
            mathProblemText.text = mathProblem;

            newQuestion = false;

            if (answerCorrect == true)
            {
                // Answer
                var mathProblemAnswer = number1 + number2;
                answerText.text = mathProblemAnswer.ToString();

                newQuestion = false;
                answerCorrect = false;

                return;
            }
            else
            {
                answerText.text = "???";
                return;
            }
        }
        else
        {
            return;
        }
    }
}
