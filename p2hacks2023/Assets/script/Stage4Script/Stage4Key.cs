using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage4Key : MonoBehaviour
{    
    // Inspector
    [SerializeField]
    private Stage4SelectItemManager stage4selectItemManager;


    bool isFlag = false;
    public GameObject gateCDObject;
    public GameObject gateCloseCDObject;
    public GameObject bagButtonObject;
    public GameObject selectImageObject;

    public GameObject GateOpenText;
    public GameObject TextPanelImage;

    private int selectedItemCheck = 0;

    void Start()
    {
        
    }

    void Update()
    {
        selectedItemCheck = Stage4SelectItemManager.instance.selectedItem;

        if(isFlag == true)
        {
            if(selectedItemCheck == 10 && Input.GetKeyDown(KeyCode.F))
            {
                GateOpenText.SetActive(true);
                TextPanelImage.SetActive(true);

                gateCloseCDObject.SetActive(false);
                bagButtonObject.SetActive(false);
                selectImageObject.SetActive(false);
                Stage4SelectItemManager.instance.selectedItem = 0;
            }
        }
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
