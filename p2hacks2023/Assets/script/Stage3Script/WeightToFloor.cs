using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightToFloor : MonoBehaviour
{
    public int weightValue = 0;
    public GameObject weight10_1;
    public GameObject weight50_1;

    public static bool pickUpPutFrag = true;//trueは置いた。falseは取った。
    private bool weight10_1PutFrag = false;
    private bool weight10_1PickUpFrag = false;
    private bool weight50_1PutFrag = false;
    private bool weight50_1PickUpFrag = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(this.gameObject.GetComponent<Collider2D>().OverlapPoint(weight10_1.transform.position)){
            //Debug.Log("重り10_1");
            if(weight10_1.activeSelf == true){
                if(pickUpPutFrag == true && weight10_1PutFrag == false){
                    weight10_1PutFrag = true;
                    weight10_1PickUpFrag = false;
                    WeightFloorValue.floorWeightTotal = WeightFloorValue.floorWeightTotal + 10;
                    Debug.Log("重り10_1置いた");
                }
            }else{
                if(pickUpPutFrag == false && weight10_1PickUpFrag == false){
                    weight10_1PickUpFrag = true;
                    weight10_1PutFrag = false;
                    WeightFloorValue.floorWeightTotal = WeightFloorValue.floorWeightTotal - 10;
                    Debug.Log("重り10_1取った");
                }
            }
        }

        if(this.gameObject.GetComponent<Collider2D>().OverlapPoint(weight50_1.transform.position)){
            //Debug.Log("重り50_1");
            if(weight50_1.activeSelf == true){
                if(pickUpPutFrag == true && weight50_1PutFrag == false){
                    weight50_1PutFrag = true;
                    weight50_1PickUpFrag = false;
                    WeightFloorValue.floorWeightTotal = WeightFloorValue.floorWeightTotal + 50;
                    Debug.Log("重り50_1置いた");
                }
            }else{
                if(pickUpPutFrag == false && weight50_1PickUpFrag == false){
                    weight50_1PickUpFrag = true;
                    weight50_1PutFrag = false;
                    WeightFloorValue.floorWeightTotal = WeightFloorValue.floorWeightTotal - 50;
                    Debug.Log("重り50_1取った");
                }
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
