using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] player;
    private Vector2 vectorPlayer;
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject vs in player)
        {
            vectorPlayer = new Vector2(vs.transform.position.x, vs.transform.position.y);
        }
        gameObject.transform.position = new Vector3(vectorPlayer.x,vectorPlayer.y,transform.position.z);
    }
}
