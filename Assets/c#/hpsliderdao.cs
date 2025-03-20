using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.UI;

public class hpsliderdao : MonoBehaviour
{
   public  Slider hpslider;
    public float firsthp=7;
    public gorillabehavior gorilla;
    // Start is called before the first frame update
    void Start()
    {
      
     hpslider.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        hpslider.value = gorilla.hp/firsthp;
        
    }
}
