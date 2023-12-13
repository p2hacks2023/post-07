using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharactorControllerPen : MonoBehaviour
{
    private Animator anim;
    private Vector2 movement;
    private Vector2 movement2; //停止している前に向いていた方向を参照するための変数
    private Transform myTransform;
    private Vector2 localPos;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        myTransform = this.transform;
        localPos = myTransform.localPosition; //ローカル座標を取得

        
        if (movement != Vector2.zero)
        {
            anim.SetFloat("X", movement.x);
            anim.SetFloat("Y", movement.y);

            //プレイヤーがもし左か下を向いていたらペンさんを右側に持ってくる
            if(movement.x == -1 || movement.y == 1) 
            {
                localPos.x = 4.0f;
                localPos.y = 2.0f;
                myTransform.localPosition = localPos;
            }

            //プレイヤーがもし右か上を向いていたらペンさんを右側に持ってくる
            if(movement.x == 1 || movement.y == -1)
            {
                localPos.x = -4.0f;
                localPos.y = 2.0f;
                myTransform.localPosition = localPos;
            }
            //Debug.Log(body.position);
            movement2 = movement;
        }else //停止していれば停止する前に向いていた方向を向かせる
        {
            anim.SetFloat("X", movement2.x);
            anim.SetFloat("Y", movement2.y);
        }
    }
}
