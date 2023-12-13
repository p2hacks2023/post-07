using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWeightFloorValue : MonoBehaviour
{
    public static int leftFloorWeightTotal = 200;//他のscriptに変更される変数
    public int initialValue = 0;//初期値

    void Start()
    {
        leftFloorWeightTotal = initialValue;
    }

    void Update()
    {
        initialValue = leftFloorWeightTotal;
        //Debug.Log(floorWeightTotal);
    }
}
