using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectItemManager : MonoBehaviour
{
    public static SelectItemManager instance = null;
    public int selectedItem = 0;
    public GameObject SelectStage1KeyImage;
    public GameObject Stage1GateCD;
    
    void Update(){
        if(selectedItem == 1){
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
