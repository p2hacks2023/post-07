using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    public GameObject destroygameObject;
    public GameObject TextPanelImage;

    // Start is called before the first frame update
    void Start()
    {
        MoveCharactorController.isText = true;
        TimeScript.isText = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(Input.GetKeyDown(KeyCode.Return))
        {
            MoveCharactorController.isText = false;
            TimeScript.isText = false;
            destroygameObject.SetActive(false);
            TextPanelImage.SetActive(false);
        }
    }
}
