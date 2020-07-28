using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float Speed = 5;

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
        transform.Translate(transform.up * Time.deltaTime * Speed);
    }

    public void MoveDown()
    {
        transform.Translate(-transform.up * Time.deltaTime * Speed);
    }

}
