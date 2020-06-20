using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private void Awake()
    {
        Main.EnemyMain.init += StartToSpawnEnemies;

    }

    private void StartToSpawnEnemies()
    {
        //TODO start coroutine to spawn enemies
        Instantiate(Main.EnemyMain.refs.prefabToSpawn);
    }
}
