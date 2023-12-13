using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3SelectItemManager : MonoBehaviour
{
    public static Stage3SelectItemManager instance = null;
    public int selectedItem = 0;
    public GameObject SelectPenchanImage;
    public GameObject SelectcalciferImage;
    public GameObject SelectWeight10_1Image;
    public GameObject Weight10_1;
    
    
    void Update(){
        if(selectedItem == 0){//何も選択していない
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(false);
            SelectWeight10_1Image.SetActive(false);
            Weight10_1.SetActive(false);
        }else if(selectedItem == 1){//ペンちゃんを選択
            SelectPenchanImage.SetActive(true);
            SelectcalciferImage.SetActive(false);
            SelectWeight10_1Image.SetActive(false);
            Weight10_1.SetActive(false);
        }else if(selectedItem == 2){//カルシファーを選択
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(true);
            SelectWeight10_1Image.SetActive(false);
            Weight10_1.SetActive(false);
        }else if(selectedItem == 4){//重り10_1を選択
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(false);
            SelectWeight10_1Image.SetActive(true);
            Weight10_1.SetActive(true);
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
