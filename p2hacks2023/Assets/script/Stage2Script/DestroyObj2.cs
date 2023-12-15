using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObj2 : MonoBehaviour
{
    public GameObject destroygameObject;
    public GameObject TextPanelImage;

    // Start is called before the first frame update
    void Start()
    {
        MoveCharactorControllerIce.isText = true;
        TimeScript2.isText = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(Input.GetKeyDown(KeyCode.Return))
        {
            MoveCharactorControllerIce.isText = false;
            TimeScript2.isText = false;
            destroygameObject.SetActive(false);
            TextPanelImage.SetActive(false);
        }
    }
}
