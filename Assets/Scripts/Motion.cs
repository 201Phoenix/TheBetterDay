using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float speed;

    private Vector2 input;

    void Start()
    {
        input = new Vector2(0.0f, 0.0f); 
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate() 
    {
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
