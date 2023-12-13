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
    //public static MoveCharactorController moveController; // MoveCharactorControllerスクリプトへの参照
    public string direction = "";
    public string directioncheck = "";

    void Start()
    {
        //moveController = MoveCharactorController.instance;
    }

    void Update()
    {
        selectedItemCheck = Stage3SelectItemManager.instance.selectedItem;
        
        //direction = moveController.GetMovementDirection();
        //if (direction != "あげぽよ"){
            
            directioncheck = MoveCharactorController.direction;
            //Debug.Log(directioncheck);
        //}
        Vector2 tmp = chara.transform.position;

        if(selectedItemCheck == 4 && Input.GetKeyDown(KeyCode.F)){
            
            
                
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
    }
}
