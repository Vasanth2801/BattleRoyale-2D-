using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float countdown = 2f; 
    public GameObject explosionEffect; 

    void Start()
    {
        Invoke("Explode", countdown);
    }

    void Explode()
    {
       
        Instantiate(explosionEffect, transform.position, Quaternion.identity);

        
        Collider2D[] objectsInRange = Physics2D.OverlapCircleAll(transform.position, 1.5f);
        foreach (Collider2D obj in objectsInRange)
        {
            if (obj.CompareTag("Player"))
            {
                obj.GetComponent<PlayerHealth>().TakeDamage();
            }
            else if (obj.CompareTag("Destructible"))
            {
                Destroy(obj.gameObject);
            }
        }

        
        Destroy(gameObject);
    }
}
