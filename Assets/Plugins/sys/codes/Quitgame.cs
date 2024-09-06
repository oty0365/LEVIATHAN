using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Quitgame : MonoBehaviour
{
    // Start is called before the first frame update
   public void Start()
    {
        #if UNITY_EDITOR//게임 컴파일 중일때만 실행하는 이프문
            EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void Mainscene()
    {
        SceneManager.LoadScene("main");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
