using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ItemDBManager : MonoBehaviour
{
   public static ItemDBManager instance = null;
   public int n = 16;
   public int itemCountManager = 0;
   public int[] array = new int[17];


   void Start()
   {
        for(int i = 0; i<array.Length; i++){
            array[i] = 0;
        }
   }

    void Update(){
        //Debug.Log(n);
        /*
        array[n] = 1;
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
         }*/
     }
}