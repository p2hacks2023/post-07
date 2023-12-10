using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[SerializeField]

public class Item : MonoBehaviour
{
    public int id;                                      //ID
    public string pokeName;                             //ポケモン名
    public int worldNum;                                //全国図鑑番号
    public int paldeaNum;                               //パルデア図鑑番号
    public decimal height;                              //重さ
    public decimal weight;                              //高さ
    public List<string> types = new List<string>();     //タイプ
    public List<string> abilities = new List<string>(); //特性
    public List<string> move = new List<string>();      //覚える技
 
    //public BaseStats baseStats = new BaseStats();       //種族値クラス
}
