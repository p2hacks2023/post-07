using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1Key : MonoBehaviour
{
    // Inspector
    [SerializeField]
    private SelectItemManager selectItemManager;

    bool isFlag = false;
    public GameObject gateCDObject;
    public GameObject gateCloseCDObject;
    public GameObject bagButtonObject;
    public GameObject selectImageObject;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isFlag == true){
            if(Input.GetKeyDown(KeyCode.F)){
                gateCloseCDObject.SetActive(false);
                bagButtonObject.SetActive(false);
                selectImageObject.SetActive(false);
                SelectItemManager.instance.selectedItem = 0;
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
