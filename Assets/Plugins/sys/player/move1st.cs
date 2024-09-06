using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class move1st : MonoBehaviour
{
    
    
    //[SerializeField] private PlayableDirector bossSatge;
    [SerializeField] int jumpPower;
    Rigidbody2D rb;
    private int movecount = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        
    }


    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            movecount++;
            if (movecount != 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            }

            //bossSatge.playableGraph.GetRootPlayable(0).SetSpeed(1);

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            movecount = 0;
            //bossSatge.playableGraph.GetRootPlayable(0).SetSpeed(0);
        }

        if (movecount == 0)
        {
            gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
        else
        {
            gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }

      

    }



}
