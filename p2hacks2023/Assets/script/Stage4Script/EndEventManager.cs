using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndEventManager : MonoBehaviour
{
    public static int checkEndCD = 0;
    public GameObject EndEventPanel;
    public GameObject TextPanelImage;

    void Start()
    {
        
    }

    void Update()
    {
        if(checkEndCD == 2 && TextPanelImage.activeSelf == false){
            EndEventPanel.SetActive(true);
        }
        
    }
}
