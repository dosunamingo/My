using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class buttondata
    : MonoBehaviour
{
    public Button targetButton;

    [SerializeField] GameObject banana;

    //押したときに呼ばれる関数
    public void OnClick()
    {
        
       
             
        //bananaの召喚
        BananaSpawn();


    }
void BananaSpawn() {
        Vector3 buttonworldPos=targetButton. transform.position;
        _ = Instantiate(banana,new Vector3(buttonworldPos.x, 297, -1
             ), transform.rotation);
            }

}
