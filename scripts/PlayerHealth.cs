using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int lives = 3; 

    public void TakeDamage()
    {
        lives--;
        if (lives <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        
        gameObject.SetActive(false); 
        Debug.Log("Player defeated!");
    }
}
