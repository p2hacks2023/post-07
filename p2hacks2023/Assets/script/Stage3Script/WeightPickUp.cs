using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WeightPickUp : MonoBehaviour
{
    bool isFlag = false;
    public GameObject itemObject;
    public GameObject itemBagObject;


    void Start()
    {
        
    }

    void Update()
    {
        if(isFlag == true){
            if(Input.GetKeyDown(KeyCode.F)){
                itemObject = this.gameObject;
                WeightToFloor.pickUpPutFrag = false;
                itemObject.SetActive(false);
                itemBagObject.SetActive(true);
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
