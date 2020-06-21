using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterController : MonoBehaviour
{

    private Motion motion;

    void Start()
    {
        motion = GetComponent<Motion>();
    }

   
    void Update()
    {
        Debug.Log(Input.GetAxis("Horizontal"));
        if (Input.GetKey(KeyCode.A))
        {
            motion.MoveLeft();
        }

        if (Input.GetKey(KeyCode.D))
        {
            motion.MoveRight();
        }

        if (Input.GetKey(KeyCode.W))
        {
            motion.MoveUp(); 
        }

        if (Input.GetKey(KeyCode.S))
        {
            motion.MoveDown();
        }
    }

    void FixedUpdate()
    {

    }
}
