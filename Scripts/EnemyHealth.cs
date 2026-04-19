using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 50;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }
private GameManager gameManager;

void Start()
{
    gameManager = FindAnyObjectByType<GameManager>();
}
    void Die()
{
    if (gameManager != null)
    {
        gameManager.AddScore(1);
    }
    else
    {
        Debug.LogWarning("GameManager not assigned!");
    }

    Destroy(gameObject);
}
}