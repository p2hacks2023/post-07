using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndEventManager : MonoBehaviour
{
    public static bool FamillySearchFlag = false;
    public static bool BatterySearchFlag = false;
    public GameObject EndEventPanel;
    public GameObject TextPanelImage;

    void Start()
    {
        
    }

    void Update()
    {
        if(FamillySearchFlag == true && BatterySearchFlag == true && TextPanelImage.activeSelf == false){
            EndEventPanel.SetActive(true);
        }
        
    }
}
