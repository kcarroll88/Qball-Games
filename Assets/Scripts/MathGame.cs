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

    [SerializeField] bool playing = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CreateMathProblem();
    }

    public void CreateMathProblem()
    {
        while (playing)
        {
            // Make random numbers between min and max range
            var number1 = UnityEngine.Random.Range(minNumber, maxNumber);
            var number2 = UnityEngine.Random.Range(minNumber, maxNumber);

            // Set Problem
            mathProblemText.text = (minNumber.ToString(), " + ", maxNumber.ToString());

            // Answer
            var mathProblemAnswer = number1 + number2;

            answerText.text = mathProblemAnswer.ToString();
            return;
        }
    }
}
