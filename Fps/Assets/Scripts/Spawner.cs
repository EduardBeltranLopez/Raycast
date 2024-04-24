using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Linq;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 15f;
    public int enemyCount;
    public int waveNumber = 1;



    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        //enemyCount = FindObjectOfType<EnemyBehabiour>().Length;

        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range (-spawnRange, spawnRange);
        float spawnPosZ = Random.Range (-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3 (spawnPosX, 1, spawnPosZ);

        return randomPos;
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
        
    }

   
}
