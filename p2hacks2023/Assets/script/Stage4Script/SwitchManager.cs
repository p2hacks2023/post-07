using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchManager : MonoBehaviour
{
    public static bool switchP1Flag = false;
    public static bool switchP2Flag = false;
    public static bool switchP3Flag = false;

    public static string switchString = "";
    private string gateOpenString = "p1p2p3";
    private bool gateOpenFlag = false;
    
    void Start()
    {
        
    }

    void Update()
    {
        if(switchString == gateOpenString && gateOpenFlag == false){
            gateOpenFlag = true;
            Debug.Log("開いちゃ");
        }
        
        if(switchP1Flag == true && switchP2Flag == true && switchP3Flag == true && gateOpenFlag == false){
            switchP1Flag = false;
            switchP2Flag = false;
            switchP3Flag = false;
        }
    }
}
