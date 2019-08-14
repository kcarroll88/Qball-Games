using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCamera : MonoBehaviour
{
    [SerializeField] float cameraSpeed;
    [Header("Audio")]
    [SerializeField] AudioClip woosh;

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

    public void MoveCameraGamePicker()
    {
        AudioSource.PlayClipAtPoint(woosh, Camera.main.transform.position);
        myAnimator.SetBool("menuClicked", false);
        myAnimator.SetBool("startClicked", true);
    }

    public void MoveCameraMainMenu()
    {
        AudioSource.PlayClipAtPoint(woosh, Camera.main.transform.position);
        myAnimator.SetBool("startClicked", false);
        myAnimator.SetBool("menuClicked", true);
    }
}
