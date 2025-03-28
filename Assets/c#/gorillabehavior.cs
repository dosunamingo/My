using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class gorillabehavior : MonoBehaviour
{
    public float speed;
    public float hp = 3.0f;
    public float firsthp;
    public float evogage = 0;
    public float evomax = 5;
    //進化したときに何倍になるか
    public float evospeedbairitu = 3;
    public float evomaxbairitu = 3;
    public float evolimit = 4;
    public float firstevolimit;


    public goriyokocollisioncheck checkCollision;
    private Rigidbody2D rb = null;
    private Animator anim = null;
    private bool rightTleftF = false;
    void Gameclear()
    {
        Time.timeScale = 0;

    }
   
    // Start is called before the first frame update
    void Start()
    {
        firsthp = hp;
        firstevolimit = evolimit;
        rb = GetComponent<Rigidbody2D>();
       anim= rb.GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (checkCollision.ison) { rightTleftF = !rightTleftF; }
        int xVector = -1;
        if (rightTleftF)
        {
            xVector = 1;
            transform.localScale = new Vector3(-8, 8, 1);
        }
        else
        {
            transform.localScale = new Vector3(8, 8, 1);
        }
        rb.velocity = new Vector2(xVector * speed, 0);
        //hp0以下になった時の処理
        if (hp <= 0)
        {  anim.SetBool("judogorillawalk",false);
        anim.SetTrigger("gorilladown");
            Destroy(gameObject, 1f);
            
        }
        //evogage maxなった時の処理
        if (evolimit > 0)
        {
            if (evogage == evomax)
            {
                evolimit -= 1;
                evogage = 0;
                evomax *= evomaxbairitu;
                speed *= evospeedbairitu;
                //ゴリラの画像進化
                if(evolimit/firstevolimit<=0.5)
                { anim.SetBool("judogorillawalk", true); }
                
            }
        }
        //ゲームクリア条件
        if (evolimit ==0) {
            Gameclear();
        }


    }
}


