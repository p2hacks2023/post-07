using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndToEventSearch : MonoBehaviour
{
    bool isFlag = false;
    public GameObject FileLoadText;
    public GameObject TextPanelImage;
    public GameObject TextFileLoad;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isFlag == true)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                FileLoadText.SetActive(true);
                TextPanelImage.SetActive(true);
                TextFileLoad.SetActive(true);

                EndEventManager.checkEndCD++;
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
