using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacterController3 : MonoBehaviour
{
    public static MoveCharacterController3 instance = null;

    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;
    public Vector2 movement;
    public static string direction = "初期ぽよ";

    public static bool isText = false; //テキスト表示中かどうかのフラグ


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        anim.SetBool("isWalk", movement != Vector2.zero);
        if (movement != Vector2.zero)
        {
            anim.SetFloat("X", movement.x);
            anim.SetFloat("Y", movement.y);
            //Debug.Log(movement.x);
            
        }

        if (movement.normalized == Vector2.up){
            direction = "上";
        }else if (movement.normalized == Vector2.down){
            direction = "下";
        }else if (movement.normalized == Vector2.left){
            direction = "左";
        }else if (movement.normalized == Vector2.right){
            direction = "右";
        }
        //Debug.Log(direction);
    }
    private void FixedUpdate()
    {
        //タイマーが0でないかつテキスト表示中でなければ動く
        if(TimeScript3.totalTime3 > 0f && isText == false){
            body.MovePosition(body.position + movement.normalized * speed * Time.fixedDeltaTime);
        }
        
    }


    public string GetMovementDirection()
    {
        

        if (movement.normalized == Vector2.up){
            direction = "上";
        }else if (movement.normalized == Vector2.down){
            direction = "下";
        }else if (movement.normalized == Vector2.left){
            direction = "左";
        }else if (movement.normalized == Vector2.right){
            direction = "右";
        }/*else{
            direction = "あげぽよ";
        }*/
        
        return direction;
    }
}
