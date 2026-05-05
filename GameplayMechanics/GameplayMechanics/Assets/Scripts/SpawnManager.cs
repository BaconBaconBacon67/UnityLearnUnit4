using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float spawnRange = 9.0f;
    public GameObject enemyPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    { Instantiate(enemyPrefab, GenerateSpawnPosition(),enemyPrefab.transform.rotation);

        
    }
    private Vector3 GenerateSpawnPosition ()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
            }

    // Update is called once per frame
    void Update()
    {
        //Instantiate(enemyPrefab, new Vector3(0, 0, 6), enemyPrefab.transform.rotation);
        
    }
}
