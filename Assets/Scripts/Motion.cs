using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{

    public float speed;

    private int _input;
    private Animator _animator;

    private const int NoMoving = -1;

    private static readonly Vector2[] InputToVector = new Vector2[4];
    private static readonly int Horizontal = Animator.StringToHash("Horizontal");
    private static readonly int Vertical = Animator.StringToHash("Vertical");
    private static readonly int IsMoving = Animator.StringToHash("isMoving");
    void Start()
    {
        InputToVector[(int)Direction.Up] = Vector2.up;
        InputToVector[(int)Direction.Down] = Vector2.down;
        InputToVector[(int)Direction.Left] = Vector2.left;
        InputToVector[(int)Direction.Right] = Vector2.right;

        _input = NoMoving;

        _animator = GetComponent<Animator>();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        UpdateMovement();
        UpdateAnimator();
        ResetInput();
    }

    private void UpdateMovement() 
    {
        if (_input != NoMoving)
        {
            Vector2 velocity = InputToVector[_input];
            _animator.SetFloat(Horizontal, velocity.x);
            _animator.SetFloat(Vertical, velocity.y);
            transform.Translate(velocity * (speed * Time.fixedDeltaTime));
        }
    }

    private void UpdateAnimator()
    {
        _animator.SetBool(IsMoving, _input != NoMoving);
    }

    private void ResetInput()
    {
        _input = NoMoving;
    }

    public void MoveUp()
    {
        _input = (int)Direction.Up;
    }

    public void MoveDown()
    {
        _input = (int)Direction.Down;
    }

    public void MoveRight()
    {
        _input = (int)Direction.Right;
    }

    public void MoveLeft()
    {
        _input = (int)Direction.Left;
    }
}
