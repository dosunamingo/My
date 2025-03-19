using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class bananamove: MonoBehaviour
{
    public enum TYPE { BANANA }
    public TYPE type = TYPE.BANANA;

    // ínñ Ç…óéÇøÇƒÇ©ÇÁÇîïbå„Ç…è¡Ç¶ÇÈ
    public float t = 2.0f;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "dodai") {
            StartCoroutine(DestroyAfterDelay());
        } }
      private IEnumerator DestroyAfterDelay()
    {
        yield return new WaitForSeconds(t);
        Destroy(gameObject);
    }
        
    
}
