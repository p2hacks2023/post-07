using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage2GameClear : MonoBehaviour
{
    bool isFlag = false;
    public string sceneName = "";

    void Start()
    {
        
    }

    void Update()
    {
        if(isFlag == true){
            GameClearManager.instance.stage2Clear = true;
            SceneManager.LoadScene(sceneName);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        isFlag = true;
    }
}
