using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
    private int stageTag;
    // Start is called before the first frame update
    public void SceneLoad()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Stage"));
    }
    
}
