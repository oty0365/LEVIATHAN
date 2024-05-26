using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammove1st : MonoBehaviour
{
    public float camspeed = 1.0f;

    private int camcount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                camcount++;
            }

            if (Input.GetKeyDown((KeyCode.Escape)))
            {
                camcount = 0;
            }
            if (camcount != 0)
            {
                transform.Translate(Vector3.right * Time.deltaTime*camspeed);    
            }
        

        
    }
}
