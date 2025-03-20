using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goriyokocollisioncheck : MonoBehaviour
{
    public bool ison = false;
    private string kabetag = "kabe";
    // Start is called before the first frame update
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.name == "migikabe"||collision.gameObject.name=="hidarikabe") { ison = true; }
   
    }
    private void OnCollisionExit2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.name == "migikabe" || collision.gameObject.name == "hidarikabe") { ison = false; }

    }
}
