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

    //‰Ÿ‚µ‚½‚Æ‚«‚ÉŒÄ‚Î‚ê‚éŠÖ”
    public void OnClick()
    {
        
       
             
        //banana‚Ì¢Š«
        BananaSpawn();

    }
void BananaSpawn() {
        Vector3 buttonworldPos=targetButton. transform.position;
        _ = Instantiate(banana,new Vector3(buttonworldPos.x, 297, -1
             ), transform.rotation);
            }

}
