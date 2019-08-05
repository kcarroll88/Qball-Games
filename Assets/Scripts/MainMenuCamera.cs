using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCamera : MonoBehaviour
{
    [SerializeField] float cameraSpeed;

    Camera mainCamera;
    Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        myAnimator = GetComponent<Animator>();
        MoveCameraMainMenu();
        myAnimator.SetBool("menuClicked", false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveCameraGamePicker()
    {
        myAnimator.SetBool("menuClicked", false);
        myAnimator.SetBool("startClicked", true);
    }

    public void MoveCameraMainMenu()
    {
        myAnimator.SetBool("startClicked", false);
        myAnimator.SetBool("menuClicked", true);
    }
}
