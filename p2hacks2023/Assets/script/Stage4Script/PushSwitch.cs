using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushSwitch : MonoBehaviour
{
    public int switchNumber = 0;
    private bool isFlag = false;

    public GameObject PushSwitchText;
    public GameObject TextPanelImage;
    public AudioSource audioSource; 
    public AudioClip audioClip;
    
    void Start()
    {
        
    }

    void Update()
    {
        //Debug.Log("isFlag:" + isFlag);
        if(isFlag == true){
            if(Input.GetKeyDown(KeyCode.F)){
                audioSource.PlayOneShot(audioClip);
                PushSwitchText.SetActive(true);
                TextPanelImage.SetActive(true);
                
                if(switchNumber == 1){
                    SwitchManager.switchP1Flag = true;
                    SwitchManager.switchString += "p1";
                    SwitchManager.switchPushNum++;
                    //Debug.Log(SwitchManager.switchPushNum);
                }else if(switchNumber == 2){
                    SwitchManager.switchP2Flag = true;
                    SwitchManager.switchString += "p2";
                    SwitchManager.switchPushNum++;
                }else if(switchNumber == 3){
                    SwitchManager.switchP3Flag = true;
                    SwitchManager.switchString += "p3";
                    SwitchManager.switchPushNum++;
                }
                //Debug.Log(SwitchManager.switchString);
            }
            
        }
        
    }

    void OnTriggerEnter2D(Collider2D col){
        isFlag = true;
    }

    void OnTriggerExit2D(Collider2D col){
        isFlag = false;
    }
}
