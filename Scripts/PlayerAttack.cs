using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int damage = 20;
    public float attackRange = 5f;
    public LayerMask enemyLayer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    void Attack()
{
    Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(transform.position, attackRange, enemyLayer);

    foreach (Collider2D enemy in hitEnemies)
    {
        Debug.Log("Enemy detected");

        EnemyHealth eh = enemy.GetComponent<EnemyHealth>();

        if (eh != null)
        {
            Debug.Log("Damage applied");
            eh.TakeDamage(damage);
        }
        else
        {
            Debug.Log("EnemyHealth script missing!");
        }
    }
}

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}