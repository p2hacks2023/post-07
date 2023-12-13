using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightWeightFloorValue : MonoBehaviour
{
    public static int rightFloorWeightTotal = 200;//他のscriptに変更される変数
    public int initialValue = 0;//初期値

    void Start()
    {
        rightFloorWeightTotal = initialValue;
    }

    void Update()
    {
        initialValue = rightFloorWeightTotal;
        //Debug.Log(floorWeightTotal);
    }
}
