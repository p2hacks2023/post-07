using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagButtonHover : MonoBehaviour
{
public GameObject OpenExplanationText;
public GameObject CloseExplanationText;

    void Start()
    {

    }

    // カーソルがボタンに入ったときに呼ばれるメソッド
    public void OnPointerEnter()
    {
        OpenExplanationText.SetActive(true);
        CloseExplanationText.SetActive(false);
    }
}
