using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1SelectItemManager : MonoBehaviour
{
    public static Stage1SelectItemManager instance = null;
    public int selectedItem = 0;
    public GameObject SelectPenchanImage;
    public GameObject SelectcalciferImage;
    public GameObject SelectStage1KeyImage;
    public GameObject Stage1GateCD;
    
    
    void Update(){
        if(selectedItem == 0){//何も選択していない
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(false);
            SelectStage1KeyImage.SetActive(false);
        }else if(selectedItem == 1){//ペンちゃんを選択
            SelectPenchanImage.SetActive(true);
            SelectcalciferImage.SetActive(false);
            SelectStage1KeyImage.SetActive(false);
        }else if(selectedItem == 2){//カルシファーを選択
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(true);
            SelectStage1KeyImage.SetActive(false);
        }else if(selectedItem == 3){//ステージ1鍵を選択
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(false);
            SelectStage1KeyImage.SetActive(true);
            Stage1GateCD.SetActive(true);
        }
    }

    private void Awake()
     {
         if(instance == null)
         {
             instance = this;
         }/*
         else
         {
             Destroy(this.gameObject);
         }*/
     }
}
