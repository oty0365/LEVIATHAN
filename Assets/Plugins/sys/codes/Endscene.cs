using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Endscene : MonoBehaviour
{
    public int CurrentSceneTag=0 ;
    // Start is called before the first frame update
    void Start()
    {
        CurrentSceneTag = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("Stage",CurrentSceneTag); 
        SceneManager.LoadScene(CurrentSceneTag+1);
    }

}
