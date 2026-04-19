using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;   // Drag your enemy prefab here
    public Transform spawnPoint;     // Where enemy will appear
    public float respawnDelay = 3f;  // Time before respawn

    private GameObject currentEnemy;
    private bool isRespawning = false;

    void Start()
    {
        SpawnEnemy();
    }

    void Update()
    {
        if (currentEnemy == null && !isRespawning)
        {
            isRespawning = true;
            Invoke(nameof(SpawnEnemy), respawnDelay);
        }
    }

    void SpawnEnemy()
{
    float x = Random.Range(-4f, 4f);
    float y = Random.Range(-3f, 3f);

    Vector2 spawnPos = new Vector2(x, y);

    currentEnemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    isRespawning = false;
}
}