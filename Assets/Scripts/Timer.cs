using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] float countdownTime;
    [SerializeField] Text timerText;
    [Header("Audio")]
    [SerializeField] AudioClip countdownBeep;

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
        if (countdownTime > 0)
        {
            if (countdownTime <= 10)
            {
                StartCoroutine(CountdownSound());
            }
            timerText.text = countdownTime.ToString("F0");
        }
        else if (countdownTime == 0)
        {
            FindObjectOfType<SceneLoader>().GameOver();
        }
    }

    IEnumerator CountdownSound()
    {
        yield return new WaitForSeconds(1f);
        AudioSource.PlayClipAtPoint(countdownBeep, Camera.main.transform.position);
    }
}
