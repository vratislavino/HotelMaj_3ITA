using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField]
    private float spawnInterval = 0.5f;
    private float spawnCooldown = 0.5f;

    [SerializeField]
    private EnemyMovement enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnCooldown > 0)
        {
            spawnCooldown -= Time.deltaTime;
            if(spawnCooldown <= 0) {
                SpawnEnemy();
                spawnCooldown = spawnInterval;
            }
        }
    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}
