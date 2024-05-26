using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thronedragon : MonoBehaviour
{
    public float rotationSpeed;
    public float movespeed=4;

    private bool canmove = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canmove = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            canmove = true;
        }
        if (canmove)
        {
            transform.Rotate(0,0,rotationSpeed);
            transform.Translate(Vector3.up * Time.deltaTime*movespeed);
        }
        
    }
}
