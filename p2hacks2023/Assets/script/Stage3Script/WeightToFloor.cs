using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightToFloor : MonoBehaviour
{
    public int weightValue = 0;
    public GameObject weight10_1;
    public GameObject weight10_2;
    public GameObject weight50_1;
    public GameObject weight50_2;
    public GameObject weight100;

    public static bool pickUpPutFrag = true;//trueは置いた。falseは取った。
    
    private bool weight10_1PutFrag = false;
    private bool weight10_1PickUpFrag = false;
    private bool weight10_2PutFrag = false;
    private bool weight10_2PickUpFrag = false;
    private bool weight50_1PutFrag = false;
    private bool weight50_1PickUpFrag = false;
    private bool weight50_2PutFrag = false;
    private bool weight50_2PickUpFrag = false;
    private bool weight100PutFrag = false;
    private bool weight100PickUpFrag = false;


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
                    
                    if(this.gameObject.name == "LeftFloor"){
                        LeftWeightFloorValue.leftFloorWeightTotal = LeftWeightFloorValue.leftFloorWeightTotal + 10;
                        //Debug.Log("左に重り10_1置いた");
                    }else{
                        RightWeightFloorValue.rightFloorWeightTotal = RightWeightFloorValue.rightFloorWeightTotal + 10;
                        //Debug.Log("右に重り10_1置いた");
                    }
                    
                }
            }else{
                if(pickUpPutFrag == false && weight10_1PickUpFrag == false){
                    weight10_1PickUpFrag = true;
                    weight10_1PutFrag = false;
                    //WeightFloorValue.floorWeightTotal = WeightFloorValue.floorWeightTotal - 10;
                    if(this.gameObject.name == "LeftFloor"){
                        LeftWeightFloorValue.leftFloorWeightTotal = LeftWeightFloorValue.leftFloorWeightTotal - 10;
                        //Debug.Log("左に重り10_1取った");
                    }else{
                        RightWeightFloorValue.rightFloorWeightTotal = RightWeightFloorValue.rightFloorWeightTotal - 10;
                        //Debug.Log("右に重り10_1取った");
                    }
                }
            }
        }

        if(this.gameObject.GetComponent<Collider2D>().OverlapPoint(weight10_2.transform.position)){
            if(weight10_2.activeSelf == true){
                if(pickUpPutFrag == true && weight10_2PutFrag == false){
                    weight10_2PutFrag = true;
                    weight10_2PickUpFrag = false;
                    if(this.gameObject.name == "LeftFloor"){
                        LeftWeightFloorValue.leftFloorWeightTotal = LeftWeightFloorValue.leftFloorWeightTotal + 10;
                    }else{
                        RightWeightFloorValue.rightFloorWeightTotal = RightWeightFloorValue.rightFloorWeightTotal + 10;
                    }
                }
            }else{
                if(pickUpPutFrag == false && weight10_2PickUpFrag == false){
                    weight10_2PickUpFrag = true;
                    weight10_2PutFrag = false;
                    if(this.gameObject.name == "LeftFloor"){
                        LeftWeightFloorValue.leftFloorWeightTotal = LeftWeightFloorValue.leftFloorWeightTotal - 10;
                    }else{
                        RightWeightFloorValue.rightFloorWeightTotal = RightWeightFloorValue.rightFloorWeightTotal - 10;
                    }
                }
            }
        }

        if(this.gameObject.GetComponent<Collider2D>().OverlapPoint(weight50_1.transform.position)){
            if(weight50_1.activeSelf == true){
                if(pickUpPutFrag == true && weight50_1PutFrag == false){
                    weight50_1PutFrag = true;
                    weight50_1PickUpFrag = false;
                    if(this.gameObject.name == "LeftFloor"){
                        LeftWeightFloorValue.leftFloorWeightTotal = LeftWeightFloorValue.leftFloorWeightTotal + 50;
                    }else{
                        RightWeightFloorValue.rightFloorWeightTotal = RightWeightFloorValue.rightFloorWeightTotal + 50;
                    }
                }
            }else{
                if(pickUpPutFrag == false && weight50_1PickUpFrag == false){
                    weight50_1PickUpFrag = true;
                    weight50_1PutFrag = false;
                    if(this.gameObject.name == "LeftFloor"){
                        LeftWeightFloorValue.leftFloorWeightTotal = LeftWeightFloorValue.leftFloorWeightTotal - 50;
                    }else{
                        RightWeightFloorValue.rightFloorWeightTotal = RightWeightFloorValue.rightFloorWeightTotal - 50;
                    }
                }
            }
        }

        if(this.gameObject.GetComponent<Collider2D>().OverlapPoint(weight50_2.transform.position)){
            if(weight50_2.activeSelf == true){
                if(pickUpPutFrag == true && weight50_2PutFrag == false){
                    weight50_2PutFrag = true;
                    weight50_2PickUpFrag = false;
                    if(this.gameObject.name == "LeftFloor"){
                        LeftWeightFloorValue.leftFloorWeightTotal = LeftWeightFloorValue.leftFloorWeightTotal + 50;
                    }else{
                        RightWeightFloorValue.rightFloorWeightTotal = RightWeightFloorValue.rightFloorWeightTotal + 50;
                    }
                }
            }else{
                if(pickUpPutFrag == false && weight50_2PickUpFrag == false){
                    weight50_2PickUpFrag = true;
                    weight50_2PutFrag = false;
                    if(this.gameObject.name == "LeftFloor"){
                        LeftWeightFloorValue.leftFloorWeightTotal = LeftWeightFloorValue.leftFloorWeightTotal - 50;
                    }else{
                        RightWeightFloorValue.rightFloorWeightTotal = RightWeightFloorValue.rightFloorWeightTotal - 50;
                    }
                }
            }
        }

        if(this.gameObject.GetComponent<Collider2D>().OverlapPoint(weight100.transform.position)){
            if(weight100.activeSelf == true){
                if(pickUpPutFrag == true && weight100PutFrag == false){
                    weight100PutFrag = true;
                    weight100PickUpFrag = false;
                    if(this.gameObject.name == "LeftFloor"){
                        LeftWeightFloorValue.leftFloorWeightTotal = LeftWeightFloorValue.leftFloorWeightTotal + 100;
                    }else{
                        RightWeightFloorValue.rightFloorWeightTotal = RightWeightFloorValue.rightFloorWeightTotal + 100;
                    }
                }
            }else{
                if(pickUpPutFrag == false && weight100PickUpFrag == false){
                    weight100PickUpFrag = true;
                    weight100PutFrag = false;
                    if(this.gameObject.name == "LeftFloor"){
                        LeftWeightFloorValue.leftFloorWeightTotal = LeftWeightFloorValue.leftFloorWeightTotal - 100;
                    }else{
                        RightWeightFloorValue.rightFloorWeightTotal = RightWeightFloorValue.rightFloorWeightTotal - 100;
                    }
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
