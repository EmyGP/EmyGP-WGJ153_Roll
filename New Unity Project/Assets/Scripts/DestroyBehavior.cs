using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBehavior : MonoBehaviour
{
    //public GameObject makiPrefab;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Destroy"))
        {
            Object.Destroy(this.gameObject);
        }       
    }
}
