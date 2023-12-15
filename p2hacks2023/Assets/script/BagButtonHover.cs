using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagButtonHover : MonoBehaviour
{
public string ExplanationText = "";

public GameObject OpenExplanation;
public Text OpenExplanationText;

    void Start()
    {

    }

    // カーソルがボタンに入ったときに呼ばれるメソッド
    public void OnPointerEnter()
    {
        OpenExplanation.SetActive(true);
        OpenExplanationText.text = ExplanationText;
    }
}
