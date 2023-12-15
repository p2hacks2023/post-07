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
    public GameObject SelectWeight50_1Image;
    public GameObject SelectWeight100_1Image;

    public GameObject Penchan;

    public GameObject Weight10_1;
    public GameObject Weight10_2;
    public GameObject Weight50_1;
    public GameObject Weight50_2;
    public GameObject Weight100;
    
    
    void Update(){
        if(selectedItem == 0){//何も選択していない
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(false);
            SelectWeight10_1Image.SetActive(false);
            SelectWeight50_1Image.SetActive(false);
            SelectWeight100_1Image.SetActive(false);
            Penchan.SetActive(false);
            Weight10_1.SetActive(false);
            Weight10_2.SetActive(false);
            Weight50_1.SetActive(false);
            Weight50_2.SetActive(false);
            Weight100.SetActive(false);
        }else if(selectedItem == 1){//ペンちゃんを選択
            SelectPenchanImage.SetActive(true);
            SelectcalciferImage.SetActive(false);
            SelectWeight10_1Image.SetActive(false);
            SelectWeight50_1Image.SetActive(false);
            SelectWeight100_1Image.SetActive(false);
            Penchan.SetActive(true);
            Weight10_1.SetActive(false);
            Weight10_2.SetActive(false);
            Weight50_1.SetActive(false);
            Weight50_2.SetActive(false);
            Weight100.SetActive(false);
        }else if(selectedItem == 2){//カルシファーを選択
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(true);
            SelectWeight10_1Image.SetActive(false);
            SelectWeight50_1Image.SetActive(false);
            SelectWeight100_1Image.SetActive(false);
            Penchan.SetActive(false);
            Weight10_1.SetActive(false);
            Weight10_2.SetActive(false);
            Weight50_1.SetActive(false);
            Weight50_2.SetActive(false);
            Weight100.SetActive(false);
        }else if(selectedItem == 4){//重り10_1を選択
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(false);
            SelectWeight10_1Image.SetActive(true);
            SelectWeight50_1Image.SetActive(false);
            SelectWeight100_1Image.SetActive(false);
            Penchan.SetActive(false);
            Weight10_1.SetActive(true);
            Weight10_2.SetActive(false);
            Weight50_1.SetActive(false);
            Weight50_2.SetActive(false);
            Weight100.SetActive(false);
        }else if(selectedItem == 5){//重り10_2を選択
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(false);
            SelectWeight10_1Image.SetActive(true);
            SelectWeight50_1Image.SetActive(false);
            SelectWeight100_1Image.SetActive(false);
            Penchan.SetActive(false);
            Weight10_1.SetActive(false);
            Weight10_2.SetActive(true);
            Weight50_1.SetActive(false);
            Weight50_2.SetActive(false);
            Weight100.SetActive(false);
        }else if(selectedItem == 6){//重り50_1を選択
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(false);
            SelectWeight10_1Image.SetActive(false);
            SelectWeight50_1Image.SetActive(true);
            SelectWeight100_1Image.SetActive(false);
            Penchan.SetActive(false);
            Weight10_1.SetActive(false);
            Weight10_2.SetActive(false);
            Weight50_1.SetActive(true);
            Weight50_2.SetActive(false);
            Weight100.SetActive(false);
        }else if(selectedItem == 7){//重り50_2を選択
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(false);
            SelectWeight10_1Image.SetActive(false);
            SelectWeight50_1Image.SetActive(true);
            SelectWeight100_1Image.SetActive(false);
            Penchan.SetActive(false);
            Weight10_1.SetActive(false);
            Weight10_2.SetActive(false);
            Weight50_1.SetActive(false);
            Weight50_2.SetActive(true);
            Weight100.SetActive(false);
        }else if(selectedItem == 8){//重り100を選択
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(false);
            SelectWeight10_1Image.SetActive(false);
            SelectWeight50_1Image.SetActive(false);
            SelectWeight100_1Image.SetActive(true);
            Penchan.SetActive(false);
            Weight10_1.SetActive(false);
            Weight10_2.SetActive(false);
            Weight50_1.SetActive(false);
            Weight50_2.SetActive(false);
            Weight100.SetActive(true);
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
