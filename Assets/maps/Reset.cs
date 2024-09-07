using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public void ResetSaveData()
    {
        PlayerPrefs.DeleteKey("Stage"); 
        PlayerPrefs.DeleteAll(); 
    }
}
