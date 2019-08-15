using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class SplashTextFade : MonoBehaviour
{
    [SerializeField] public float fadeOutTime;
    [SerializeField] public float fadeInTime;

    public bool transparent;

    void Update() 
    {
        if (transparent) 
        {
            // StartCoroutine(FadeIn());
        }
        else if (!transparent)
        {
            StartCoroutine(FadeOut());
        }
        
    }

    // private IEnumerator FadeIn()
    // {
    //     transparent = true;
    // }

    private IEnumerator FadeOut()
    {
        transparent = false;

        Text text = GetComponent<Text>();
        Color originalColor = text.color;

        for (float t = 0.01f; t < fadeOutTime; t += Time.deltaTime)
        {
            text.color = Color.Lerp(originalColor, Color.clear, Mathf.Min(1, t / fadeOutTime));
            yield return null;
        }
    }
}
