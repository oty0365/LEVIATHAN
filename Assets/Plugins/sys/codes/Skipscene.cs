using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Skipscene : MonoBehaviour
{
    public int CurrentSceneTag=0 ;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            CurrentSceneTag = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(CurrentSceneTag+1);
        }

    }
}