using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startbattle : MonoBehaviour
{
    public GameObject handler;
    // Start is called before the first frame update
    void Start()
    {
        handler.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            handler.SetActive(true);
        }
    }
}
