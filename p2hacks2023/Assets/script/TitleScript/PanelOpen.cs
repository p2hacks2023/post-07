using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpen : MonoBehaviour
{
    public GameObject OpenPanel;

    void Start()
    {
        
    }

    public void OnButtonClick()
    {
        // パネルの表示状態を切り替える
        //if (panelToShow != null)
        //{
        OpenPanel.SetActive(true);
        //}
    }
}
