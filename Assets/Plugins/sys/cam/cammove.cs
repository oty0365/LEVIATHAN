using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammove : MonoBehaviour
{
    public float camspeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(Vector3.right * Time.deltaTime*camspeed);    
    }
}
