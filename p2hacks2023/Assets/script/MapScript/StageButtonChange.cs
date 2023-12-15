using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageButtonChange : MonoBehaviour
{
    public GameObject stage1ClearText;
    public GameObject stage2ClearText;
    public GameObject stage3ClearText;
    public GameObject stage4ClearText;

    void Start()
    {
        
    }


    void Update()
    {
        if(GameClearManager.instance.stage1Clear == true){
            stage1ClearText.SetActive(true);
        }
        if(GameClearManager.instance.stage2Clear == true){
            stage2ClearText.SetActive(true);
        }
        if(GameClearManager.instance.stage3Clear == true){
            stage3ClearText.SetActive(true);
        }
        if(GameClearManager.instance.stage4Clear == true){
            stage4ClearText.SetActive(true);
        }
    }
}
