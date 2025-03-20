using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gorillabehavior : MonoBehaviour
{
    public float speed;
    public float hp = 3.0f;
    public goriyokocollisioncheck checkCollision;
    private Rigidbody2D rb = null;
    private bool rightTleftF = false;
    // Start is called before the first frame update
    void Start()
    {
       rb= GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (checkCollision.ison) { rightTleftF=!rightTleftF; }
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
        rb.velocity=new Vector2(xVector*speed, 0);
        
    }
}
