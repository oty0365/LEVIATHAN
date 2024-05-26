using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.Rendering;

public class gamestart : MonoBehaviour
{
    
    public int sn;
    // Start is called before the first frame update
    public void OnClickExit()
    {
        //GameObject a = GameObject.Find("clear");
        //a.GetComponent<Nextlevel>()
        SceneManager.LoadScene("ending");
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameSelect()
    {
        SceneManager.LoadScene("select");
    }
}
