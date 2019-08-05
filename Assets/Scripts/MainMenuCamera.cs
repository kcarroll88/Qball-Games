using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCamera : MonoBehaviour
{
    [SerializeField] float cameraSpeed;

    Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        MoveCameraMainMenu();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveCameraGamePicker()
    {
        mainCamera.transform.position = new Vector3(20, transform.position.y, -10);
    }

    public void MoveCameraMainMenu()
    {
        mainCamera.transform.position = new Vector3(0, 0, -10);
    }
}
