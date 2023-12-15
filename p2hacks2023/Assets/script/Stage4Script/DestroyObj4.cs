using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObj4 : MonoBehaviour
{
    public GameObject destroygameObject;
    public GameObject TextPanelImage;
    
    // Start is called before the first frame update
    void Start()
    {
        MoveCharactorController4.isText = true;
        TimeScript4.isText = true;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharactorController4.isText = true;
        TimeScript4.isText = true;
        
        if(Input.GetKeyDown(KeyCode.Return))
        {
            MoveCharactorController4.isText = false;
            TimeScript4.isText = false;
            destroygameObject.SetActive(false);
            TextPanelImage.SetActive(false);
        }
    }
}
