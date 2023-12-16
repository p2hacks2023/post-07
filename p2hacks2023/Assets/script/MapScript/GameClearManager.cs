using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearManager : MonoBehaviour
{
    public bool prologue = false;
    public bool stage1Clear = false;
    public bool stage2Clear = false;
    public bool stage3Clear = false;
    public bool stage4Clear = false;
    public static GameClearManager instance = null;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void Awake()
     {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject); 
        }
        else
        {
            Destroy(this.gameObject);
        }
     }
}
