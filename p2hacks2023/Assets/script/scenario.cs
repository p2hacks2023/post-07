using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenario : MonoBehaviour
{
    [SerializeField]
    private bool isLast;
    [SerializeField]
    private GameObject next_scenario;
    [SerializeField]
    private GameObject story;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(isLast == false)
            {
                next_scenario.SetActive(true);
            }
            
            story.SetActive(false);
        }
    }
}
