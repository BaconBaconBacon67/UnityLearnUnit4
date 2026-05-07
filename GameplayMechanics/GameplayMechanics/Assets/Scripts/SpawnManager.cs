using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float spawnRange = 9.0f;
    public GameObject enemyPrefab;
    public int waveNumber = 1;
    public GameObject powerupPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(powerupPrefab, GenerateSpawnPosition(),
            powerupPrefab.transform.rotation);
    
    }
    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(),
            enemyPrefab.transform.rotation);
        }
    }

        private Vector3 GenerateSpawnPosition ()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
            }

    // Update is called once per frame

    public int enemyCount;
    void Update()
    {
        enemyCount = FindObjectsByType<Enemy>(FindObjectsSortMode.None).Length;

       if(enemyCount == 0)
        {
         
            Instantiate(enemyPrefab, GenerateSpawnPosition(),
            enemyPrefab.transform.rotation);
            waveNumber++; SpawnEnemyWave(waveNumber);
        }
     

    }
}
