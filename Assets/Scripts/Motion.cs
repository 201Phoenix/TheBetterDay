using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{

    public float speed;

    private Vector2 input;
    private Animator animator;
    private int isMovingParamID;

    void Start()
    {
        input = new Vector2(0.0f, 0.0f);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    { 
        animator.SetBool("isMoving", System.Math.Abs(input.SqrMagnitude()) > 0.0f ? true : false); 
        
        float dx = Time.fixedDeltaTime * input.x * speed;
        float dy = Time.fixedDeltaTime * input.y * speed;
        transform.position += new Vector3(dx, dy);
        input.x = 0.0f;
        input.y = 0.0f;
        
    }

    public void MoveUp()
    {
        input.y += 1;
    }

    public void MoveDown() 
    {
        input.y -= 1;
    }

    public void MoveLeft()
    {
        input.x -= 1;
    }

    public void MoveRight()
    {
        input.x += 1;
    }
}
