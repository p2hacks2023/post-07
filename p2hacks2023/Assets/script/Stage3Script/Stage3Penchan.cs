using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3Penchan : MonoBehaviour
{
    public GameObject PenchanPanel;
    public GameObject FrontPanel;
    public GameObject ItemTextPanel10_1;
    public GameObject ItemTextPanel10_2;
    public GameObject ItemTextPanel50_1;
    public GameObject ItemTextPanel50_2;
    public GameObject ItemTextPanel100_1;
    public GameObject ItemTextPanelIce;
    
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && PenchanPanel.activeSelf == false){
            PenchanPanel.SetActive(true);
            FrontPanel.SetActive(false);
            ItemTextPanel10_1.SetActive(true);
            ItemTextPanel10_2.SetActive(true);
            ItemTextPanel50_1.SetActive(true);
            ItemTextPanel50_2.SetActive(true);
            ItemTextPanel100_1.SetActive(true);
            ItemTextPanelIce.SetActive(true);

            //〇秒後に呼び出す
            Invoke(nameof(DelayMethod), 3.5f);
        }
    }

    void DelayMethod()
    {
        PenchanPanel.SetActive(false);
        FrontPanel.SetActive(true);
        ItemTextPanel10_1.SetActive(false);
        ItemTextPanel10_2.SetActive(false);
        ItemTextPanel50_1.SetActive(false);
        ItemTextPanel50_2.SetActive(false);
        ItemTextPanel100_1.SetActive(false);
        ItemTextPanelIce.SetActive(false);
    }

    private void OnDestroy()
    {
        // Destroy時に登録したInvokeをすべてキャンセル
        CancelInvoke();
    }
}
