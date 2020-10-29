
using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    //sending value to anyone listening
    public Vector2 OnMovementInput { get; set; }
    //sending direction to target
    public Vector3 OnMovementDirectionInput { get; set; }
    private Camera mainCamera;

    private void Start()
    {
        //locking cursor to center screen
        Cursor.lockState = CursorLockMode.Locked;
        mainCamera = Camera.main;

    }

    private void Update()
    {
        GetMovementInput();
        GetMovementDirection();
    }

    private void GetMovementDirection()
    {
        OnMovementInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //if anything is listening to delagate, send input
       // Debug.Log(OnMovementInput);
    }

    private void GetMovementInput()
    {

        var cameraForwardDir = mainCamera.transform.forward;
        //Debug.DrawRay(mainCamera.transform.position, cameraForwardDir * 10, Color.red);

        OnMovementDirectionInput = Vector3.Scale(cameraForwardDir, (Vector3.right + Vector3.forward));
      //  Debug.DrawRay(mainCamera.transform.position, directionMoveIn * 10, Color.blue);
       
    }
}
