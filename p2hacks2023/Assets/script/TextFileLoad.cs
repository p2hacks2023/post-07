using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFileLoad : MonoBehaviour
{
    public GameObject TextPanelTmage;
    public GameObject Text;

    [SerializeField]
    private Text textLabel;
 
    [SerializeField]
    private TextAsset textFile;
 
    private string textData;
    private string[] splitText;
 
    private int currentNum = 0;
 
    void Start () {
        textData = textFile.text;
        splitText = textData.Split(char.Parse("\n"));
 
        textLabel.text = splitText[currentNum];
    }
 
    private void Update(){
        if (Input.GetKeyDown(KeyCode.Return)){
            if(currentNum < splitText.Length){
                textLabel.text = splitText[currentNum];
                currentNum++;
                
            }else{
                TextPanelTmage.SetActive(false);
                Text.SetActive(false);
                this.gameObject.SetActive(false);
            }
        }
    }
}
