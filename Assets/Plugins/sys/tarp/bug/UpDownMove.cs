using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownMove : MonoBehaviour
{
    public float speed = 3;
    public GameObject goal;

    private int canacction = 0;
    // Start is called before the first frame update
    void Start()
    {
        canacction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (canacction > 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, goal.transform.position, speed*Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            canacction++;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canacction = 0;
        }        
    }
    
}
