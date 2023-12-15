using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour
{

    // Inspector
    [SerializeField]
    private Stage3SelectItemManager stage3selectItemManager;

    
    public GameObject weight;
    public GameObject chara;
    public GameObject weightBagButton;

    private int selectedItemCheck = 0;
    private bool selectedWeight = false;
    public string directioncheck = "";

    void Start()
    {
        
    }

    void Update()
    {
        selectedItemCheck = Stage3SelectItemManager.instance.selectedItem;
        
            
        directioncheck = MoveCharacterController3.direction;
        //Debug.Log(directioncheck);
        
        Vector2 tmp = chara.transform.position;

        if(selectedItemCheck == 4 || selectedItemCheck == 5 || selectedItemCheck == 6 || selectedItemCheck == 7 || selectedItemCheck == 8){
            selectedWeight = true;
        }

        if(selectedWeight == true && Input.GetKeyDown(KeyCode.F)){
            //if(WeightPickUp.isFlag == false){
            
                // 向きによる条件分岐
                if (directioncheck == "上")
                {
                    weight.transform.position = new Vector2(tmp.x, tmp.y+1);
                }
                else if (directioncheck == "下")
                {
                    weight.transform.position = new Vector2(tmp.x, tmp.y-1);
                }
                else if (directioncheck == "左")
                {
                    weight.transform.position = new Vector2(tmp.x-1, tmp.y);
                }
                else if (directioncheck == "右")
                {
                    weight.transform.position = new Vector2(tmp.x+1, tmp.y);
                }
            
                WeightToFloor.pickUpPutFrag = true;
                weight.SetActive(true);
                weightBagButton.SetActive(false);
                Stage3SelectItemManager.instance.selectedItem = 0;
            }
        //}
    }
}
