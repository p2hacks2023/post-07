using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTextController : MonoBehaviour
{
    public GameObject TextPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        if(FadeChangeScene.EndTitleScene == true)
        {
            TextPanel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        FadeChangeScene.EndTitleScene = false;
    }
}
