using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class SplashTextFade : MonoBehaviour
{
   public bool transparent = false;

    Animator myAnimator;

    void Start() 
    {
        myAnimator = GetComponent<Animator>();
        myAnimator.SetBool("isTransparent", false);
        myAnimator.SetBool("isTransparent", true);
    }
}
