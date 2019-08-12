using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] float countdownTime;
    [SerializeField] Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = countdownTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Countdown();
    }

    private void Countdown()
    {
        countdownTime -= Time.deltaTime;
        if (countdownTime >= 0)
        {
            timerText.text = countdownTime.ToString("F0");
        }
        else if (countdownTime == 0)
        {
            FindObjectOfType<SceneLoader>().GameOver();
        }
    }
}
