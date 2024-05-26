using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggermovingsuriken : MonoBehaviour
{
    public int time = 10;
    public float movespeed = 4;
    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Player"))
        {
            for (i = 0; i <= time; i++)
            {
                transform.Translate(Vector3.up * Time.deltaTime*movespeed);
            }
        }
        
    }
}
