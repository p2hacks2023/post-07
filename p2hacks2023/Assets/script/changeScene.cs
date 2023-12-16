using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    
    public bool StageButton;
    public GameObject stageClearText;
    
    public void LoadScene(string sceneName)
    {
        if(StageButton == true)
        {
            if(stageClearText.activeSelf)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
        
        
        
    }
}
