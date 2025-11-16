using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

public class ThirdPersonPlayerWalk : MonoBehaviour
{
    InputActions inputActions;

    private InputAction _moveAction;
    private InputAction _lookAction;
    private InputAction _jumpAction;

    private Vector2 _move;
    private Vector2 _look;
    private Animator _animator;
    private Rigidbody _rigidbody;

    [Inject]
    public void Construct(InputActions inputActions)
    {
        this.inputActions = inputActions;
    }
}
