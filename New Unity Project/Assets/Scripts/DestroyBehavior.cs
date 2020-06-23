using UnityEngine;

public class DestroyBehavior : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Destroy"))
        {
            Object.Destroy(this.gameObject);
        } 
    }
}
