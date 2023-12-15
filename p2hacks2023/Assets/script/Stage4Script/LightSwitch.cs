using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    private bool isFlag = false;
    public GameObject SwitchGlobalLight;
    public GameObject GlobalLight;
    public GameObject CharaLight;
    public GameObject EndCD;

    public GameObject FileLoadText;
    public GameObject TextPanelImage;
    public GameObject LightSwitchTextFileLoad;

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

                EndCD.SetActive(true);
                FileLoadText.SetActive(true);
                TextPanelImage.SetActive(true);
                LightSwitchTextFileLoad.SetActive(true);
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
