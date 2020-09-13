﻿using System;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody rb;

    public float Speed = 5;
    private float VerticalSpeed;

    public void MoveForward()
    {
        transform.Translate(transform.forward * Time.deltaTime * Speed);
    }

    public void MoveBackward()
    {
        transform.Translate(-transform.forward * Time.deltaTime * Speed);
    }

    public void MoveRight()
    {
        transform.Translate(transform.right * Time.deltaTime * Speed);
    }

    public void MoveLeft()
    {
        transform.Translate(-transform.right * Time.deltaTime * Speed);
    }

    public void MoveUp()
    {
        VerticalSpeed += Time.deltaTime * Speed;
    }

    public void MoveDown()
    {
        VerticalSpeed -= Time.deltaTime * Speed;
    }

    public void RotateRight()
    {
        transform.Rotate(new Vector3(0,120*Time.deltaTime));
    }

    public void RotateLeft()
    {
        transform.Rotate(new Vector3(0,-120*Time.deltaTime));
    }

    private void FixedUpdate()
    {
        // countering gravity
        rb.AddForce(transform.up * Physics.gravity.magnitude);

        // setting vertical speed
        rb.AddForce(transform.up * VerticalSpeed * Speed);
        VerticalSpeed = 0;
    }

}

