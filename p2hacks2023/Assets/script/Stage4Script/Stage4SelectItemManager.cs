using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage4SelectItemManager : MonoBehaviour
{
    public static Stage4SelectItemManager instance = null;
    public int selectedItem = 0;
    public GameObject SelectPenchanImage;
    public GameObject SelectcalciferImage;
    public GameObject SelectPaperImage;
    public GameObject SelectStage4KeyImage;
    public GameObject GateCD;
    
    
    void Update(){
        if(selectedItem == 0){//何も選択していない
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(false);
            SelectPaperImage.SetActive(false);
            SelectStage4KeyImage.SetActive(false);
            GateCD.SetActive(false);
        }else if(selectedItem == 1){//ペンちゃんを選択
            SelectPenchanImage.SetActive(true);
            SelectcalciferImage.SetActive(false);
            SelectPaperImage.SetActive(false);
            SelectStage4KeyImage.SetActive(false);
            GateCD.SetActive(false);
        }else if(selectedItem == 2){//カルシファーを選択
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(true);
            SelectPaperImage.SetActive(false);
            SelectStage4KeyImage.SetActive(false);
            GateCD.SetActive(false);
        }else if(selectedItem == 9){//スイッチについての紙を選択
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(false);
            SelectPaperImage.SetActive(true);
            SelectStage4KeyImage.SetActive(false);
            GateCD.SetActive(false);
        }else if(selectedItem == 10){//ステージ4鍵を選択
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(false);
            SelectPaperImage.SetActive(false);
            SelectStage4KeyImage.SetActive(true);
            GateCD.SetActive(true);
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
