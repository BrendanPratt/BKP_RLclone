using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public CharacterController CharacterController;

    private void Update()
    {

        if (Input.GetAxis("Y Axis") < -0.5)
        {
            CharacterController.MoveForward();
        }
        if (Input.GetAxis("Y Axis") > 0.5)
        {
            CharacterController.MoveBackward();
        }
        if (Input.GetAxis("X Axis") < -0.5)
        {
            CharacterController.MoveRight();
        }
        if (Input.GetAxis("X Axis") > 0.5)
        {
            CharacterController.MoveLeft();
        }
        if (Input.GetAxis("Z Axis") < -0.5)
        {
            CharacterController.MoveUp();
        }
        if (Input.GetAxis("Z Axis") > 0.5)
        {
            CharacterController.MoveDown();
        }
        if (Input.GetAxis("Rot Axis") < -0.5)
        {
            CharacterController.RotateLeft();
        }
        if (Input.GetAxis("Rot Axis") > 0.5)
        {
            CharacterController.RotateRight();
        }
    }
}
