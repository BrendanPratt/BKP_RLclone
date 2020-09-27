using System;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody rb;

    public float Speed;
    private float Yspeed;
    private float Xspeed;
    private float Zspeed;

    public void MoveForward()
    {
        Zspeed += 25 * Time.deltaTime * Speed;
    }

    public void MoveBackward()
    {
        Zspeed -= 25 * Time.deltaTime * Speed;
    }

    public void MoveRight()
    {
        Xspeed += 25 * Time.deltaTime * Speed;
    }

    public void MoveLeft()
    {
        Xspeed -= 25 * Time.deltaTime * Speed;
    }

    public void MoveUp()
    {
        Yspeed += 25 * Time.deltaTime * Speed;
    }

    public void MoveDown()
    {
        Yspeed -= 25 * Time.deltaTime * Speed;
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
        // control drag
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y - rb.velocity.y * Time.deltaTime * 3, rb.velocity.z);

        // countering gravity
        rb.AddForce(transform.up * Physics.gravity.magnitude);

        // setting vertical speed
        rb.AddForce(transform.right * Xspeed * Speed);
        rb.AddForce(transform.up * Yspeed * Speed);
        rb.AddForce(transform.forward * Zspeed * Speed);
        Xspeed = 0;
        Yspeed = 0;
        Zspeed = 0;
    }
}

