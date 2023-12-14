using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushSwitch : MonoBehaviour
{
    public int switchNumber = 0;
    private bool isFlag = false;
    
    void Start()
    {
        
    }

    void Update()
    {
        //Debug.Log("isFlag:" + isFlag);
        if(isFlag == true){
            if(Input.GetKeyDown(KeyCode.F)){
                if(switchNumber == 1){
                    SwitchManager.switchP1Flag = true;
                    SwitchManager.switchString += "p1";
                }else if(switchNumber == 2){
                    SwitchManager.switchP2Flag = true;
                    SwitchManager.switchString += "p2";
                }else if(switchNumber == 3){
                    SwitchManager.switchP3Flag = true;
                    SwitchManager.switchString += "p3";
                }
                Debug.Log(SwitchManager.switchString);
            }
            
        }
        //Debug.Log(isFlag);
    }

    void OnTriggerEnter2D(Collider2D col){
        isFlag = true;
    }

    void OnTriggerExit2D(Collider2D col){
        isFlag = false;
    }
}
