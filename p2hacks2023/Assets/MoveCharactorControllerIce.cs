using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharactorControllerIce : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float icezone_horizon;
    private Rigidbody2D body;
    //private Animator anim;
    private Vector2 movement;
    private Vector2 movement2;
    private int flag = 0;   //移動の入力を受け付けるかどうかのフラグ

    // Start is called before the first frame update
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        //anim.SetBool("isWalk", movement != Vector2.zero);
        //if (movement != Vector2.zero)
        //{
            //anim.SetFloat("X", movement.x);
            //anim.SetFloat("Y", movement.y);
            //Debug.Log(body.position);
        //}

        //初期状態またはキャラが壁に当たったら、進行方向をmovement2に保存
        if(this.flag == 0)
        {
            if(Input.GetKey(KeyCode.W))
            {
                this.flag = 1;
                movement2.x = movement.x;
                movement2.y = movement.y;
            }

            if(Input.GetKey(KeyCode.S))
            {
                this.flag = 1;
                movement2.x = movement.x;
                movement2.y = movement.y;
            }

            if(Input.GetKey(KeyCode.D))
            {
                this.flag = 1;
                movement2.x = movement.x;
                movement2.y = movement.y;
            }

            if(Input.GetKey(KeyCode.A))
            {
                this.flag = 1;
                movement2.x = movement.x;
                movement2.y = movement.y;
            }
        }
        
        //壁に当たるまで一定の方向で動き続ける
        else
        {
            if(this.transform.position.x > icezone_horizon)
            {
                body.MovePosition(body.position + movement2.normalized * speed);
            }else
            {
                body.MovePosition(body.position + movement.normalized * speed);
            }
            //body.MovePosition(body.position + movement2.normalized * speed);
        }
        
        Debug.Log(this.transform.position);
        
    }

    //もしあたった壁が現在の進行方向に立ちはだかる壁であればフラグを0にする
    private void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Vertical wall"))
        {
            if(movement2.x != 0)
            {
                this.flag = 0;
            } 
        }
        if(other.gameObject.CompareTag("Landscape wall"))
        {
            if(movement2.y != 0)
            {
                this.flag = 0;
            } 
        }
    }
}
