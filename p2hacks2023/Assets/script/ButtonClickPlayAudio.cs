using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickPlayAudio : MonoBehaviour
{
    public Button button;       
    public AudioSource audioSource; 
    public AudioClip audioClip;

    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnButtonClick()
    {
        audioSource.PlayOneShot(audioClip);

    }
}
