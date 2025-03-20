using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goriyokocollisioncheck : MonoBehaviour


{
    public gorillabehavior gorilla;
    //壁にあたると反転（たぶん機能してないけど挙動は上手くいってるので放置中）
    public bool ison = false;
    private string kabetag = "kabe";
    // Start is called before the first frame update
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.name == "migikabe"||collision.gameObject.name=="hidarikabe") { ison = true; }

        //バナナとあたると進化ゲージがたまる
        if (collision.gameObject.CompareTag("banana"))
        {
            gorilla.evogage += 1;
        }
    }
    private void OnCollisionExit2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.name == "migikabe" || collision.gameObject.name == "hidarikabe") { ison = false; }

    }
  
    

     


    
}
