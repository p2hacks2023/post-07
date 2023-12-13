using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightFloorValue : MonoBehaviour
{
    public static int floorWeightTotal = 200;//他のscriptに変更される変数
    public int initialValue = 0;//初期値

    void Start()
    {
        floorWeightTotal = initialValue;
    }

    void Update()
    {
        initialValue = floorWeightTotal;
        //Debug.Log(floorWeightTotal);
    }
}
