using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class lighteater : MonoBehaviour
{
    [SerializeField] private PlayableDirector bossSatge;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            bossSatge.playableGraph.GetRootPlayable(0).SetSpeed(1);

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            bossSatge.playableGraph.GetRootPlayable(0).SetSpeed(0);
        }
        
    }
}
