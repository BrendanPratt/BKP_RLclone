﻿using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody Rigidbody;
    
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

    private void FixedUpdate()
    {
        // countering gravity
        Rigidbody.AddForce(transform.up * Physics.gravity.magnitude);

        // setting vertical speed
        Rigidbody.AddForce(transform.up * VerticalSpeed);
        
        VerticalSpeed = 0;

    }
}

