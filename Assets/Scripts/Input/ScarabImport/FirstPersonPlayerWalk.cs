using System;
using UnityEngine;

public class FirstPersonPlayerWalk : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    [SerializeField] private float movementSpeed = 1f;

    private Vector3 movement;

    internal void Move(Vector2 movementInput)
    {
        movement = (transform.right * movementInput.x + transform.forward * movementInput.y) * movementSpeed;
        characterController.Move(movement * Time.deltaTime);
    }
}