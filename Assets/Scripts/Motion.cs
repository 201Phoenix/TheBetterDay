using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{

    public float speed;

    private int input;
    private Animator animator;

    private const int NO_MOVE = -1;

    private Vector2[] inputToVector = new Vector2[4];

    private const string IS_MOVING_PARAM_NAME = "isMoving";
    private const string DIRECTION_PARAM_NAME = "direction";
    void Start()
    {
        inputToVector[(int)Direction.Up] = Vector2.up;
        inputToVector[(int)Direction.Down] = Vector2.down;
        inputToVector[(int)Direction.Left] = Vector2.left;
        inputToVector[(int)Direction.Right] = Vector2.right;

        input = NO_MOVE;

        animator = GetComponent<Animator>();
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
        if (input != NO_MOVE)
        {
            animator.SetFloat("Horizontal", inputToVector[input].x);
            animator.SetFloat("Vertical", inputToVector[input].y);
            Vector2 velocity = inputToVector[input];
            transform.Translate(velocity * speed * Time.fixedDeltaTime);
        }
    }

    private void UpdateAnimator()
    {
        if (input != NO_MOVE)
        {
            animator.SetBool(IS_MOVING_PARAM_NAME, true);
            animator.SetInteger(DIRECTION_PARAM_NAME, input);
        }
        else
        {
            animator.SetBool(IS_MOVING_PARAM_NAME, false);
        }

    }

    private void ResetInput()
    {
        input = NO_MOVE;
    }

    public void MoveUp()
    {
        input = (int)Direction.Up;
    }

    public void MoveDown()
    {
        input = (int)Direction.Down;
    }

    public void MoveRight()
    {
        input = (int)Direction.Right;
    }

    public void MoveLeft()
    {
        input = (int)Direction.Left;
    }
}
