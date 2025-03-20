using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class bananamove: MonoBehaviour
{
    public enum TYPE { BANANA }
    public TYPE type = TYPE.BANANA;
    
        

    // 地面に落ちてからｔ秒後に消える
    public float t = 2.0f;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.name == "uehanntei") { Destroy(gameObject,0.1f); }
        if (other.collider.name == "yokohanntei") { Destroy (gameObject,0.1f); }   
        if (other.gameObject.name == "dodai") {
            StartCoroutine(DestroyAfterDelay());
        } }

      private IEnumerator DestroyAfterDelay()
    {
        yield return new WaitForSeconds(t);
        Destroy(gameObject);
    }
        
    
}
