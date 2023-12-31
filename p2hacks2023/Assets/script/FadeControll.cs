using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeControll : MonoBehaviour
{
    public GameObject StartText;
    public GameObject TextPanelTmage;
    [SerializeField] private GameObject FadeTarget;
    Color color;

    void Start()
    {
        color = FadeTarget.GetComponent<Image>().color;
        color.a = 1f;
        FadeTarget.GetComponent<Image>().color = color;

        //別の方法
        //gameObject.GetComponent<Image>().color = new Color(0.8f, 0.3f, 0.1f, 0.5f);
    }

    void Update(){
        color.a -= 0.008f;
        FadeTarget.GetComponent<Image>().color = color;

        if(color.a <= 0.45f){
            StartText.SetActive(true);
            TextPanelTmage.SetActive(true);
            FadeTarget.SetActive(false);
        }
    }
}
