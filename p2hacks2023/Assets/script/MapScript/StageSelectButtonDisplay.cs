using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelectButtonDisplay : MonoBehaviour
{
    public GameObject StageSelectButton;
    public GameObject TextPanelImage;

    void Start()
    {
        
    }

    void Update()
    {
        if(TextPanelImage.activeSelf == false){
            StageSelectButton.SetActive(true);
            GameClearManager.instance.prologue = true;
        }

        if(GameClearManager.instance.prologue == true){
            TextPanelImage.SetActive(false);
        }
    }
}
