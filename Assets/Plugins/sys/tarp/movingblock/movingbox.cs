using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingbox : MonoBehaviour
{
    public float speed;

    public int startingPoint;
    private int i;
    private bool canmove=true;
    public Transform[] points;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[startingPoint].position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            i++;
            if (i == points.Length)
            {
                i = 0;
            }
            
        }

        if (canmove)
        {
            transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canmove = false;
        }

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            canmove = true;
        }

    }
}
