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
    [SerializeField] Slider gagebar;
    bool isclicked=false;
    Button button=>GetComponent<Button>();
    private void Update()
    {

        if (!isclicked) { button.interactable = true; }
        else { button.interactable = false; }
    }

    //�������Ƃ��ɌĂ΂��֐�
    public void OnClick()
    {
        
       isclicked = true;
             
        //banana�̏���
        BananaSpawn();
        //�Q�[�W
        StartCoroutine(SliderUpdate());

    }
void BananaSpawn() {
        Vector3 buttonworldPos=targetButton. transform.position;
        _ = Instantiate(banana,new Vector3(buttonworldPos.x, 297, -1
             ), transform.rotation);
            }
    IEnumerator SliderUpdate() {
        gagebar.value = 0;
        gagebar.gameObject.SetActive(true);
        while (gagebar.value < gagebar.maxValue)
        {
            gagebar.value++;
            yield return new WaitForSeconds(0.1f);
        }
        gagebar.gameObject.SetActive(false);
        isclicked = false;

    }


}
