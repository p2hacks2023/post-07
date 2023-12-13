using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3Penchan : MonoBehaviour
{
    public GameObject PenchanPanel;
    
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && PenchanPanel.activeSelf == false){
            PenchanPanel.SetActive(true);

            //〇秒後に呼び出す
            Invoke(nameof(DelayMethod), 3.5f);
        }
    }

    void DelayMethod()
    {
        PenchanPanel.SetActive(false);
    }

    private void OnDestroy()
    {
        // Destroy時に登録したInvokeをすべてキャンセル
        CancelInvoke();
    }
}
