using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DG.Tweening;

public class Nextlevel : MonoBehaviour
{
    private string savePath;
    
    public static int CurrentSceneTag=0 ;
    public Animator transistionAnim;
    public AudioSource source;
    public float fadeTime = 1f;
    public static bool musiconsound = true;

    private void Start()
    {
        transistionAnim.SetBool("End",false);
        transistionAnim.SetBool("Start",true);
        CurrentSceneTag = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("Stage",CurrentSceneTag);
        //Debug.Log(CurrentSceneTag);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            musiconsound = false;
            //DontDestroyOnLoad(gameObject);
            source.DOFade(0f, 1.5f);
            StartCoroutine(Wait());


        }
    }

    IEnumerator Wait()
    {
        transistionAnim.SetBool("End",true);
        transistionAnim.SetBool("Start",false);

        yield return new WaitForSeconds(1.4f);
        SceneManager.LoadScene(CurrentSceneTag+1);
    }
}
