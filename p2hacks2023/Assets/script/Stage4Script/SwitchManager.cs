using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchManager : MonoBehaviour
{
    public GameObject Stage4KeyBagButton;
    public GameObject SwitchText;
    public GameObject TextPanelImage;
    public GameObject SwitchOpenTextFileLoad;
    public GameObject SwitchResetTextFileLoad;

    public static bool switchP1Flag = false;
    public static bool switchP2Flag = false;
    public static bool switchP3Flag = false;

    public static string switchString = "";
    private string gateOpenString = "p1p2p3";
    private bool gateOpenFlag = false;
    private bool switchResetFlag = false;
    
    void Start()
    {
        
    }

    void Update()
    {
        if(switchString == gateOpenString && gateOpenFlag == false){
            gateOpenFlag = true;
            Stage4KeyBagButton.SetActive(true);
            
       
        }

        if(gateOpenFlag == true){
            
            if(Input.GetKeyDown(KeyCode.Return)){
                Debug.Log("開いちゃ");
                SwitchOpenTextFileLoad.SetActive(true);
                SwitchText.SetActive(true);
                TextPanelImage.SetActive(true);
                
            }
        }else if(TextPanelImage.activeSelf == false){
            SwitchOpenTextFileLoad.SetActive(false);
        }
        
        if(switchP1Flag == true && switchP2Flag == true && switchP3Flag == true && gateOpenFlag == false){
            switchP1Flag = false;
            switchP2Flag = false;
            switchP3Flag = false;
            switchString = "";
            switchResetFlag = true;
            Debug.Log("やりなおし");
        }

        if(switchResetFlag == true && gateOpenFlag == false){
            
            if(Input.GetKeyDown(KeyCode.Return)){
                SwitchResetTextFileLoad.SetActive(true);
                SwitchText.SetActive(true);
                TextPanelImage.SetActive(true);
                switchResetFlag = false;
            }
        }else if(TextPanelImage.activeSelf == false){
            SwitchResetTextFileLoad.SetActive(false);
        }
    }
}
