using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goriyokocollisioncheck : MonoBehaviour


{
    public gorillabehavior gorilla;
    //�ǂɂ�����Ɣ��]�i���Ԃ�@�\���ĂȂ����ǋ����͏�肭�����Ă�̂ŕ��u���j
    public bool ison = false;
    private string kabetag = "kabe";
    // Start is called before the first frame update
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.name == "migikabe"||collision.gameObject.name=="hidarikabe") { ison = true; }

        //�o�i�i�Ƃ�����Ɛi���Q�[�W�����܂�
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
