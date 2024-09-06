using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Returngame : MonoBehaviour
{
    public void Returning()
    {
        SceneManager.LoadScene(Nextlevel.CurrentSceneTag);
    }
}
