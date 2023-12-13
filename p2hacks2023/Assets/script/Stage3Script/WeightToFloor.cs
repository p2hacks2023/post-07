using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightToFloor : MonoBehaviour
{
    public int weightValue = 0;
    public GameObject weight;

    public static bool pickUpPutFrag = true;//trueは置いた。falseは取った。
    private bool weight10_1PutFrag = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.GetComponent<Collider2D>().OverlapPoint(weight.transform.position)){
            if(pickUpPutFrag == true && weight10_1PutFrag == false){
                weight10_1PutFrag = true;
                Debug.Log("置いた");
            }
            if(pickUpPutFrag == false){
                Debug.Log("取った");
            }
        }
    }
/*
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == weightFloor){
            Debug.Log("置いた");
        }
    }


    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("取った");
    }*/
}
