using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour
{
    bool isFlag = false;
    public GameObject itemObject;
    public GameObject itemBagObject;
    public GameObject itemText;
    public GameObject TextPanelImage;

    //public GameObject itemExplanationTextPanel;



    //bool isItemtextFlag = false;
    //public Text itemExplanationText;
    //public String itemName;


    void Start()
    {
        //itemExplanationTextPanel.SetActive(false);
    }

    void Update()
    {
        if(isFlag == true){
            if(Input.GetKeyDown(KeyCode.F)){
                itemObject = this.gameObject;
                itemObject.SetActive(false);
                itemBagObject.SetActive(true);

                itemText.SetActive(true);
                TextPanelImage.SetActive(true);

                //itemExplanationTextPanel.SetActive(true);
                //isItemtextFlag = true;
            }
            
        }
        

        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        isFlag = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        isFlag = false;
    }
}
