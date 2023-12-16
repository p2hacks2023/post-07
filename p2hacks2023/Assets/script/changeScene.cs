using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    
    public bool StageButton;
    public GameObject stageClearText;
    
    [SerializeField]
    private bool SelectEnding;
    [SerializeField]
    private GameObject EndEventPanel;
    
    public void LoadScene(string sceneName)
    {
        if(StageButton == true)
        {
            if(stageClearText.activeSelf)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
        else if(SelectEnding == true)
        {
            EndEventPanel.SetActive(false);
            EndEventManager.FamillySearchFlag = false;
            EndEventManager.BatterySearchFlag = false;
            SwitchManager.switchP1Flag = false;
            SwitchManager.switchP2Flag = false;
            SwitchManager.switchP3Flag = false;
            SwitchManager.switchPushNum = 0;

            SwitchManager.switchString = "";
            SwitchManager.gateOpenString = "p1p2p3";
            SwitchManager.gateOpenFlag = false;
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
        
        
        
    }
}
