using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFileLoad4 : MonoBehaviour
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
    
    // Start is called before the first frame update
    void Start()
    {
        textData = textFile.text;
        splitText = textData.Split(char.Parse("\n"));
 
        textLabel.text = splitText[currentNum];
        MoveCharactorController4.isText = true;
        TimeScript4.isText = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)){
            if(currentNum < splitText.Length){
                textLabel.text = splitText[currentNum];
                currentNum++;
                
            }else{
                MoveCharactorController4.isText = false;
                TimeScript4.isText = false;
                TextPanelTmage.SetActive(false);
                Text.SetActive(false);
                this.gameObject.SetActive(false);
            }
        }
    }
}
