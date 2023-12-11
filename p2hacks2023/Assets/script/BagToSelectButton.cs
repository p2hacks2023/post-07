using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagToSelectButton : MonoBehaviour
{
    // Inspector
    [SerializeField]
    private Stage1SelectItemManager selectItemManager;

    //public SelectItemManager selectItemManager;

    public Button itemButton;
    public int selectedItemId = 1;

    void Start()
    {
        itemButton.onClick.AddListener(ChangeSelectedItem);
    }

    public void ChangeSelectedItem(){
        //SelectItemManager selectedItem = new SelectItemManager();//インスタンス化
        Stage1SelectItemManager.instance.selectedItem = selectedItemId;
    }
}
