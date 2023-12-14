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
    
    
    void Update(){
        if(selectedItem == 0){//何も選択していない
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(false);
            SelectPaperImage.SetActive(false);
        }else if(selectedItem == 1){//ペンちゃんを選択
            SelectPenchanImage.SetActive(true);
            SelectcalciferImage.SetActive(false);
            SelectPaperImage.SetActive(false);
        }else if(selectedItem == 2){//カルシファーを選択
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(true);
            SelectPaperImage.SetActive(false);
        }else if(selectedItem == 9){//ステージ1鍵を選択
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(false);
            SelectPaperImage.SetActive(true);
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
