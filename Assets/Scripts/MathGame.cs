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
            var number1 = UnityEngine.Random.Range(minNumber, maxNumber);
            var number2 = UnityEngine.Random.Range(minNumber, maxNumber);
            var mathProblem = number1 + number2;

            mathProblemText.text = mathProblem.ToString();
            return;
        }
    }
}
