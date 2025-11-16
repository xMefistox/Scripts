using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScarabImportInputManager : MonoBehaviour
{
    [SerializeField] private FirstPersonCameraController cameraController;
    [SerializeField] private FirstPersonPlayerWalk movementController;
    [SerializeField] private CameraRaycast interactController;

    private InputActions inputActions;

    private Vector2 movementInput;
    private Vector2 mouseInput;

    private void Awake()
    {
        inputActions = new InputActions();

        inputActions.Player.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        inputActions.Player.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();
        inputActions.Player.LeftMouse.performed += OnLeftMouseClicked;
        inputActions.Player.Movement.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
        inputActions.Player.CloseGame.performed += ctx => Application.Quit();
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnDisable()
    {
        inputActions.Player.Disable();
    }

    private void Update()
    {
        cameraController.UpdateCamera(mouseInput);
        movementController.Move(movementInput);
    }

    private void OnLeftMouseClicked(InputAction.CallbackContext context)
    {
        interactController.TryInteracting();
    }
}
