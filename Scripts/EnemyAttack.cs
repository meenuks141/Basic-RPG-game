using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage = 10;
    public float attackCooldown = 1f;

    private float lastAttackTime;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Time.time >= lastAttackTime + attackCooldown)
            {
                collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
                lastAttackTime = Time.time;
            }
        }
    }
}