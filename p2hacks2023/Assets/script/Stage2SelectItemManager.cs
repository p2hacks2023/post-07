using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2SelectItemManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static Stage2SelectItemManager instance = null;
    public int selectedItem = 0;
    public GameObject SelectPenchanImage;
    public GameObject SelectcalciferImage;
    //public GameObject SelectStage1KeyImage;
    //public GameObject Stage1GateCD;
    void Start()
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

    // Update is called once per frame
    void Update()
    {
        if(selectedItem == 0){//何も選択していない
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(false);
            //SelectStage1KeyImage.SetActive(false);
        }else if(selectedItem == 1){//ペンちゃんを選択
            SelectPenchanImage.SetActive(true);
            SelectcalciferImage.SetActive(false);
            //SelectStage1KeyImage.SetActive(false);
        }else if(selectedItem == 2){//カルシファーを選択
            SelectPenchanImage.SetActive(false);
            SelectcalciferImage.SetActive(true);
            //SelectStage1KeyImage.SetActive(false);
        }
    }
}
