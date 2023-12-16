using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeChangeScene : MonoBehaviour
{
    [SerializeField] private GameObject FadeImage;
    public string sceneNameString;
    Color color;

    public static bool EndTitleScene = false; 

    void Start()
    {
        color = FadeImage.GetComponent<SpriteRenderer>().color;
        color.a = 0f;
        FadeImage.GetComponent<SpriteRenderer>().color = color;
        EndTitleScene = true;
    }
/*
    public void OnClick(){

        FadeControll();


        //if(color.a <= 0.45f){
            
        //}
    }*/

    void Update(){
        //while(color.a <= 1f){
            color.a += 0.008f;
            FadeImage.GetComponent<SpriteRenderer>().color = color;
        //}
        if(color.a >= 1f){
            LoadScene(sceneNameString);
        }

        //LoadScene(sceneNameString);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
