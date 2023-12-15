using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharactorControllerIce : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float icezone_horizon; //氷と安全地帯の境目のx座標(stage2専用)
    private Rigidbody2D body;
    private Animator anim;
    private Vector2 movement;
    private Vector2 movement2;//入力を保存しておく用の変数(stage2専用)
    private Vector2 restartpoint;
    private int flag = 0;   //移動の入力を受け付けるかどうかのフラグ(stage2専用)
    private int Iceflag = 0;   //安全地帯に行ったかフラグ(stage2専用)

    public static bool isText; //テキスト出力中かどうかのフラグ
    

    // Start is called before the first frame update
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        anim.SetBool("isWalk", ((movement != Vector2.zero) && (this.transform.position.x >= icezone_horizon)));

        if (movement != Vector2.zero)
        {
            anim.SetFloat("X", movement.x);
            anim.SetFloat("Y", movement.y);
            //Debug.Log(body.position);
        }

        //もしプレイヤーのいる場所が氷の場所であれば
        if(this.transform.position.x < icezone_horizon)
        {
            //安全地帯から氷に戻る場合は新たに入力を受け付ける
            if(Iceflag == 1)
            {
                this.flag = 0;
                Iceflag = 0;
            }
            
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
            }else
            {
                //制限時間以内かつテキスト再生中ではない場合
                if(TimeScript2.totalTime2 > 0　&& isText == false)
                {
                    body.MovePosition(body.position + movement2.normalized * speed);
                }
                
            }
            //Debug.Log("ice");

        }else　　//氷の場所にいないかつ時間以内かつテキスト再生中ではない場合は普通に移動
        {
            if(TimeScript2.totalTime2 > 0 && isText == false){
                body.MovePosition(body.position + movement.normalized * speed);
                //Debug.Log("no ice");
                Iceflag = 1;
            }
            
        }
        
        //Debug.Log(movement2);
        
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
