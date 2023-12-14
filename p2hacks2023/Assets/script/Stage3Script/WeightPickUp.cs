using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WeightPickUp : MonoBehaviour
{
    // Inspector
    [SerializeField]
    private Stage3SelectItemManager stage3selectItemManager;

    public bool isFlag = false;
    public int itemId = 0;
    public GameObject itemObject;
    public GameObject itemBagObject;

    public GameObject weightExplanationTextPanel;

    void Start()
    {
        weightExplanationTextPanel.SetActive(false);
    }

    void Update()
    {
        if(isFlag == true){
            if(Input.GetKeyDown(KeyCode.F)){
                itemObject = this.gameObject;
                WeightToFloor.pickUpPutFrag = false;
                itemObject.SetActive(false);
                itemBagObject.SetActive(true);

                weightExplanationTextPanel.SetActive(true);

                /*if(Stage3SelectItemManager.instance.selectedItem == 0){
                    Stage3SelectItemManager.instance.selectedItem = itemId;
                }*///選択していないとき拾ったら選択にする(選択している状態で拾ったとき置いちゃう)
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
