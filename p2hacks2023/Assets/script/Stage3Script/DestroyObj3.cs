using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj3 : MonoBehaviour
{
    public GameObject destroygameObject;
    public GameObject TextPanelImage;

    // Start is called before the first frame update
    void Start()
    {
        MoveCharacterController3.isText = true;
        TimeScript3.isText = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(Input.GetKeyDown(KeyCode.Return))
        {
            MoveCharacterController3.isText = false;
            TimeScript3.isText = false;
            destroygameObject.SetActive(false);
            TextPanelImage.SetActive(false);
        }
    }
}
