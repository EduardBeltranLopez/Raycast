using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< Updated upstream
//using System.Linq;
=======
using System.Linq;
>>>>>>> Stashed changes

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
<<<<<<< Updated upstream
    private float spawnRange = 15f;
    public int enemyCount;
=======
    private float spawnRangeX = 17f;
    private float spawnRangeZ = 5f;

    public int enemyCount = 24;
>>>>>>> Stashed changes
    public int waveNumber = 1;



    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
<<<<<<< Updated upstream
=======
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        //enemyCount = FindObjectOfType<EnemyBehabiour>().Length;
=======
        enemyCount = FindObjectsOfType<EnemyBehabiour>().Length;
>>>>>>> Stashed changes

        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
<<<<<<< Updated upstream
=======
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
>>>>>>> Stashed changes
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
<<<<<<< Updated upstream
        float spawnPosX = Random.Range (-spawnRange, spawnRange);
        float spawnPosZ = Random.Range (-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3 (spawnPosX, 1, spawnPosZ);
=======
        float spawnPosX = Random.Range (-spawnRangeX, spawnRangeX);
        float spawnPosZ = Random.Range (-spawnRangeZ, spawnRangeZ);

        Vector3 randomPos = new Vector3 (spawnPosX, 5, spawnPosZ);
>>>>>>> Stashed changes

        return randomPos;
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
<<<<<<< Updated upstream
        for (int i = 0; i < enemiesToSpawn; i++)
=======
        for (int i = 0; i < enemiesToSpawn;i++)
>>>>>>> Stashed changes
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
        
    }

   
}
