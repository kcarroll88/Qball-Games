using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class SplashTextFade : MonoBehaviour
{
    // [SerializeField] public float fadeOutTime;
    // [SerializeField] public float fadeInTime;

    public bool transparent = false;

    Animator myAnimator;

    void Start() 
    {
        myAnimator = GetComponent<Animator>();
        myAnimator.SetBool("isTransparent", false);
        myAnimator.SetBool("isTransparent", true);
    }
}
