using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage3GameClear : MonoBehaviour
{
    bool isFlag = false;
    public string sceneName = "";

    void Start()
    {
        
    }

    void Update()
    {
        if(isFlag == true){
            GameClearManager.instance.stage3Clear = true;
            SceneManager.LoadScene(sceneName);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        isFlag = true;
    }
}
