using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHoverColor : MonoBehaviour
{
    public GameObject panelToShow; // 表示するパネルへの参照
    public Color normalColor = Color.white; // 通常の色
    public Color hoverColor = Color.white; // ホバー時の色

    private Button button;

    void Start()
    {
        button = GetComponent<Button>();

        if (button != null)
        {
            // 通常の色を設定
            button.image.color = normalColor;

            // ホバー時の色を設定
            ColorBlock colors = button.colors;
            colors.highlightedColor = hoverColor;
            button.colors = colors;
        }
    }
}
