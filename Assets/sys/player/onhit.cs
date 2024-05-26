using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class onhit : MonoBehaviour
{
    [SerializeField] Image hit;
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public float health=4;
    public Light2D light;
    public float lightfallout=0.5f;
    private Coroutine _coroutine;
    private bool isultimate = false;

    

    private void Start()
    {
        hit.enabled = false;
        gameObject.GetComponent<CircleCollider2D>().enabled = true;
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = spriteArray[0];
        
    }
    

    private void Update()
    {
        if (health==3)
        {
            spriteRenderer.sprite = spriteArray[1];
           
        }
        else if (health==2)
        {
            spriteRenderer.sprite = spriteArray[2];
            
        }
        else if (health==1)
        {
            spriteRenderer.sprite = spriteArray[3];
           
        }
        else if (health<=0)
        {
            lightfallout += 0.15f ;
            SceneManager.LoadScene("gameover");
        }
        
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("traps"))
        {
            health = health - 1;
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
            hit.enabled = true;
            if(_coroutine != null) StopCoroutine(_coroutine);
            _coroutine = StartCoroutine(LightChange(Mathf.Clamp01(lightfallout + .15f)));
            Invoke(nameof(Gothit),0.7f);
            
            //SceneManager.LoadScene("gameover");
        }
        else if (collision.gameObject.CompareTag("walls"))
        {
            if(isultimate==false){health=-1;}
            
        }
        else if (collision.gameObject.CompareTag("enemy"))
        {
            health = -1;
        }
        else if (collision.gameObject.CompareTag("clear"))
        {
            isultimate = true;
            health = 10000;
        }
    }

    private IEnumerator LightChange(float to)
    {
        for (var i = 0f; i < 0.5; i += Time.deltaTime)
        {
            light.falloffIntensity = lightfallout = Mathf.Lerp(lightfallout, to, .05f);
            yield return null;
        }

        light.falloffIntensity = lightfallout = to;
    }

    void Gothit()
    {
        hit.enabled = false;
        gameObject.GetComponent<CircleCollider2D>().enabled = true;
    }

    /*void Gotclear()
    {
        _coroutine = StartCoroutine(LightChange(Mathf.Clamp01(lightfallout + .5f)));
    }*/
}


