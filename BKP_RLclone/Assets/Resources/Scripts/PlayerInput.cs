using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public CharacterController CharacterController;

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            CharacterController.MoveForward();
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            CharacterController.MoveBackward();
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            CharacterController.MoveLeft();
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            CharacterController.MoveRight();
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            CharacterController.MoveUp();
        }
        if (Input.GetKey(KeyCode.Space))
        {
            CharacterController.MoveDown();
        }
    }
}

