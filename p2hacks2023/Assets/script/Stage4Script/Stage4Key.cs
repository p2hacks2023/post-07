using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage4Key : MonoBehaviour
{    
    // Inspector
    [SerializeField]
    private Stage4SelectItemManager stage4selectItemManager;


    bool isFlag = false;
    public GameObject gateCDObject;
    public GameObject gateCloseCDObject;
    public GameObject gateCloseBackground;
    public GameObject bagButtonObject;
    public GameObject selectImageObject;

    public GameObject GateOpenText;
    public GameObject TextPanelImage;

    public AudioSource audioSource; 
    public AudioClip audioClip;

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
                audioSource.PlayOneShot(audioClip);

                GateOpenText.SetActive(true);
                TextPanelImage.SetActive(true);

                gateCloseCDObject.SetActive(false);
                bagButtonObject.SetActive(false);
                selectImageObject.SetActive(false);
                gateCloseBackground.SetActive(false);

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
