using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    Rigidbody2D myRigidbody;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveClouds();
    }

    private void MoveClouds()
    {
        transform.Translate (Vector2.right * moveSpeed * Time.deltaTime);
    }
}
