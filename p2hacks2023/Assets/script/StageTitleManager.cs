using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageTitleManager : MonoBehaviour
{
    public GameObject FadeControll;

    public Text textComponent;
    public string fullText;
    public float delay = 0.1f;

    private void Start()
    {
        textComponent.text = "";
        StartCoroutine(TypeText());
        
    }

    IEnumerator TypeText()
    {
        foreach (char c in fullText)
        {
            
            textComponent.text += c;
            yield return new WaitForSeconds(delay);
        }
        FadeControll.SetActive(true);
    }
}
