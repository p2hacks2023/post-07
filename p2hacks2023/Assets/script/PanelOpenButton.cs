using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpenButton : MonoBehaviour
{
    public Button openButton; // ボタンへの参照
    public GameObject openPanel; // パネルへの参照

    // Start is called before the first frame update
    void Start()
    {
        // ボタンのクリックイベントにメソッドを追加
        openButton.onClick.AddListener(ActivatePanel);
    }

    void ActivatePanel()
    {
        // パネルをアクティブにする
        openPanel.SetActive(true);
    }
}
