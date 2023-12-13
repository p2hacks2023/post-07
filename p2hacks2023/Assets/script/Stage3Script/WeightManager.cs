using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightManager : MonoBehaviour
{
    private int leftValue = 0;
    private int rightValue = 0;

    public GameObject leftHeavy;
    public GameObject rightHeavy;
    public GameObject gateCD;

    void Start()
    {
        
    }

    void Update()
    {
        leftValue = LeftWeightFloorValue.leftFloorWeightTotal;
        rightValue = RightWeightFloorValue.rightFloorWeightTotal;

        if(leftValue > rightValue){
            leftHeavy.SetActive(true);
            rightHeavy.SetActive(false);
        }else if(leftValue < rightValue){
            leftHeavy.SetActive(false);
            rightHeavy.SetActive(true);
        }else if(leftValue == rightValue){
            leftHeavy.SetActive(true);
            rightHeavy.SetActive(true);
        }

        if(leftHeavy.activeSelf == true && rightHeavy.activeSelf == true){
            gateCD.SetActive(false);
        }else{
            gateCD.SetActive(true);
        }
    }
}
