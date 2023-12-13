using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage1calciferice1 : MonoBehaviour
{
    private Stage1SelectItemManager stage1selectItemManager;

    bool isFlag1 = false;
    bool isFlag2 = false;
    public GameObject iceWallCDObject1;
    public GameObject iceWallCloseCDObject1;

    [SerializeField]
    private GameObject iceExplanationTextPanel;

    private int selectedItemCheck = 0;

    // Start is called before the first frame update
    void Start()
    {
        iceExplanationTextPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        selectedItemCheck = Stage1SelectItemManager.instance.selectedItem;

        if(isFlag1 == true)
        {
            if(isFlag2 == false)
            {
                iceExplanationTextPanel.SetActive(true);
                isFlag2 = true;
            }

            if(selectedItemCheck == 2 && Input.GetKeyDown(KeyCode.F))
            {
                iceWallCloseCDObject1.SetActive(false);
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
        isFlag1 = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        isFlag1 = false;
    }
}
