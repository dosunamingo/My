using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class gorillabehavior : MonoBehaviour
{
    public float speed;
    public float hp = 3.0f;
    public float evogage = 0;
    public float evomax = 5;
    //êiâªÇµÇΩÇ∆Ç´Ç…âΩî{Ç…Ç»ÇÈÇ©
    public float evospeedbairitu = 3;
    public float evomaxbairitu = 3;


    public goriyokocollisioncheck checkCollision;
    private Rigidbody2D rb = null;
    private bool rightTleftF = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

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
        //hp0à»â∫Ç…Ç»Ç¡ÇΩéûÇÃèàóù
        if (hp <= 0)
        {
            gameObject.SetActive(false);
        }
        //evogage maxÇ»Ç¡ÇΩéûÇÃèàóù
        if (evogage == evomax)
        {
            evogage = 0;
            evomax *= evomaxbairitu;
            speed *= evospeedbairitu;
        }


    }
}


