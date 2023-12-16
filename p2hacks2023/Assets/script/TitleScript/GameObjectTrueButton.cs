using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectTrueButton : MonoBehaviour
{
    
    [SerializeField] private GameObject TrueObject;

    public void OnClick(){
        TrueObject.SetActive(true);
    }
}
