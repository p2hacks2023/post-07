using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1Calcifer : MonoBehaviour
{
    // Inspector
    [SerializeField]
    private Stage1SelectItemManager stage1selectItemManager;

    bool isFlag = false;
    public GameObject iceWallCDObject;
    public GameObject iceWallCloseCDObject;
    //[SerializeField]
    //private GameObject iceExplanationTextPanel;

    private int selectedItemCheck = 0;
    
    void Start()
    {
        //iceExplanationTextPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        selectedItemCheck = Stage1SelectItemManager.instance.selectedItem;

        if(isFlag == true)
        {
            //iceExplanationTextPanel.SetActive(true);

            if(selectedItemCheck == 2 && Input.GetKeyDown(KeyCode.F))
            {
                iceWallCloseCDObject.SetActive(false);
            }
        }

        /*if(isFlag == true && selectedItemCheck == 2){
            if(Input.GetKeyDown(KeyCode.F)){
                iceWallCloseCDObject.SetActive(false);
                itemExplanationTextPanel.SetActive(true);
            }
        }*/
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
