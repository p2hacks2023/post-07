using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndToEventSearch : MonoBehaviour
{
    bool isFlag = false;
    public int FamillyOrBattery = 0;
    public GameObject FileLoadText;
    public GameObject TextPanelImage;
    public GameObject TextFileLoad;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isFlag == true)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                FileLoadText.SetActive(true);
                TextPanelImage.SetActive(true);
                TextFileLoad.SetActive(true);


                if(FamillyOrBattery == 1){
                    EndEventManager.FamillySearchFlag = true;
                }else if(FamillyOrBattery == 2){
                    EndEventManager.BatterySearchFlag = true;
                }
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
