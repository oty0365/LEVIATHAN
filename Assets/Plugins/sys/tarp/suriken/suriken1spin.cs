using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suriken1spin : MonoBehaviour
{
    public float rotationSpeed;
    private int canmove=0;
    // Start is called before the first frame update
    void Start()
    {
        canmove = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(canmove!=0)
        {
            transform.Rotate(0,0,rotationSpeed); 
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            canmove++;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canmove = 0;
        }
    }
}
