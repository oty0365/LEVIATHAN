using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cleargame3 : MonoBehaviour
{
    public static Cleargame3 instance;

    [SerializeField] private Animator transistionAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(Nextlevel());
    }

    IEnumerator Nextlevel()
    {
        transistionAnim.SetTrigger("SceneEnd");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex+1));
        transistionAnim.SetTrigger("SceneStart");
    }
    
    
}
