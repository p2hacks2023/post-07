using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelCloseButton : MonoBehaviour
{
    public Button closeButton; // ボタンへの参照
    public GameObject closePanel; // パネルへの参照

    // Start is called before the first frame update
    void Start()
    {
        // ボタンのクリックイベントにメソッドを追加
        closeButton.onClick.AddListener(PassivePanel);
    }

    void PassivePanel()
    {
        // パネルを非アクティブにする
        closePanel.SetActive(false);
    }
}