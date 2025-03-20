using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class evosliderdao : MonoBehaviour
{

    public Slider  evoslider;
   
    public gorillabehavior gorilla;
    // Start is called before the first frame update
    void Start()
    {

        evoslider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        evoslider.value = gorilla.evogage / gorilla.evomax;

    }
}
