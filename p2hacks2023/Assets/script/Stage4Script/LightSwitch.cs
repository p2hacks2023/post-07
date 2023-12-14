using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    private bool isFlag = false;
    public GameObject SwitchGlobalLight;
    public GameObject GlobalLight;
    public GameObject CharaLight;

    void Start()
    {
        
    }

    void Update()
    {
        if(isFlag == true){
            if(Input.GetKeyDown(KeyCode.F)){
                GlobalLight.SetActive(false);
                SwitchGlobalLight.SetActive(true);
                CharaLight.SetActive(false);
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
