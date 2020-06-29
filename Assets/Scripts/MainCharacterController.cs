using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterController : MonoBehaviour
{

    private Motion _motion;

    void Start()
    {
        _motion = GetComponent<Motion>();
    }

   
    void Update()
    {
        Debug.Log(Input.GetAxis("Horizontal"));
        if (Input.GetKey(KeyCode.A))
        {
            _motion.MoveLeft();
        }

        if (Input.GetKey(KeyCode.D))
        {
            _motion.MoveRight();
        }

        if (Input.GetKey(KeyCode.W))
        {
            _motion.MoveUp(); 
        }

        if (Input.GetKey(KeyCode.S))
        {
            _motion.MoveDown();
        }
    }

    void FixedUpdate()
    {

    }
}
