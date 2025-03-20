using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goriuecollisioncheck : MonoBehaviour
{
   
    public gorillabehavior gorilla;
    public float bananadamege = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("banana"))
            {
            gorilla.hp -= bananadamege;
            }
        

    }
}
