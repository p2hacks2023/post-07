using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1Key : MonoBehaviour
{
    // Inspector
    [SerializeField]
    private Stage1SelectItemManager stage1selectItemManager;
    [SerializeField]
    private GameObject gateExplanationText;
    [SerializeField]
    private GameObject TextPanelImage;


    bool isFlag = false;
    bool isFlag2 = false;
    public GameObject gateCDObject;
    public GameObject gateCloseCDObject;
    public GameObject bagButtonObject;
    public GameObject selectImageObject;

    private int selectedItemCheck = 0;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        selectedItemCheck = Stage1SelectItemManager.instance.selectedItem;

        if(isFlag == true)
        {
            if(isFlag2 == false)
            {
                gateExplanationText.SetActive(true);
                TextPanelImage.SetActive(true);
                isFlag2 = true;
            }

            if(selectedItemCheck == 3 && Input.GetKeyDown(KeyCode.F))
            {
                gateCloseCDObject.SetActive(false);
                bagButtonObject.SetActive(false);
                selectImageObject.SetActive(false);
                Stage1SelectItemManager.instance.selectedItem = 0;
            }
        }
        
        /*if(isFlag == true && selectedItemCheck == 3){
            if(Input.GetKeyDown(KeyCode.F)){
                gateCloseCDObject.SetActive(false);
                bagButtonObject.SetActive(false);
                selectImageObject.SetActive(false);
                Stage1SelectItemManager.instance.selectedItem = 0;
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
