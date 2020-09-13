using System;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody rb;

    public float Speed = 5;
    private float VerticalSpeed;

    public void HaltMovement()
    {
        rb.velocity = new Vector3(0, rb.velocity.y, 0);
    }

    public void MoveForward()
    {
        Vector3 force = transform.forward * Speed;
        rb.velocity = new Vector3(force.x, rb.velocity.y, force.z);
    }

    public void MoveBackward()
    {
        Vector3 force = -transform.forward * Speed;
        rb.velocity = new Vector3(force.x, rb.velocity.y, force.z);
    }

    public void MoveRight()
    {
        Vector3 force = transform.right * Speed;
        rb.velocity = new Vector3(force.x, rb.velocity.y, force.z);
    }

    public void MoveLeft()
    {
        Vector3 force = -transform.right * Speed;
        rb.velocity = new Vector3(force.x, rb.velocity.y, force.z);
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

