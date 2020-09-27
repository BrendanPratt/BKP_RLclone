using System;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody rb;

    public float Speed;
    private float Yspeed;
    private float Xspeed;
    private float Zspeed;


    public void HaltMovement()
    {
        rb.velocity = new Vector3(0, rb.velocity.y, 0);
    }

    public void MoveForward()
    {
        Zspeed += 25 * Time.deltaTime * Speed;
        //Vector3 force = transform.forward * Speed;
        //rb.velocity = new Vector3(force.x, rb.velocity.y, force.z);
    }

    public void MoveBackward()
    {
        Zspeed -= 25 * Time.deltaTime * Speed;
        //Vector3 force = -transform.forward * Speed;
        //rb.velocity = new Vector3(force.x, rb.velocity.y, force.z);
    }

    public void MoveRight()
    {
        Xspeed += 25 * Time.deltaTime * Speed;
        //Vector3 force = transform.right * Speed;
        //rb.velocity = new Vector3(force.x, rb.velocity.y, force.z);
    }

    public void MoveLeft()
    {
        Xspeed -= 25 * Time.deltaTime * Speed;
        //Vector3 force = -transform.right * Speed;
        //rb.velocity = new Vector3(force.x, rb.velocity.y, force.z);
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

