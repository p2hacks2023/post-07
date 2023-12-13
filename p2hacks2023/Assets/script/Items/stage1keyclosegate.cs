using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage1keyclosegate : MonoBehaviour
{
    [SerializeField]
    private GameObject gateExplanationTextPanel;

    private bool isFlag;
    // Start is called before the first frame update
    void Start()
    {
        gateExplanationTextPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isFlag == true)
        {
            gateExplanationTextPanel.SetActive(true);

        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        isFlag = true;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        isFlag = false;
    }
}
