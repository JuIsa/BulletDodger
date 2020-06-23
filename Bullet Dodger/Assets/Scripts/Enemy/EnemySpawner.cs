using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private bool isGameOver = false;
    private void Awake()
    {
        Main.EnemyMain.init += StartToSpawnEnemies;
        Main.EnemyMain.onGameOver += ChangeBool;
    }


    private void ChangeBool()
    {
        isGameOver = true;
    }

    private void StartToSpawnEnemies()
    {
        StartCoroutine(corSpawnEnemy());
    }

    private IEnumerator corSpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            Vector3 randomPosition = UtilityCustom.GetRandomPosition();
            Vector3 destination = UtilityCustom.GetDestination();
            if (!isGameOver)
            {
                if (Main.EnemyMain.enemiesPool.Count != 0)
                    GetEnemyFromPool(randomPosition, destination);
                else
                    SpawnNewEnemy(randomPosition, destination);
            }
        }
    }

    private void SpawnNewEnemy(Vector3 randomPosition, Vector3 destination)
    {
        EnemyContent go = Instantiate(Main.EnemyMain.refs.enemyPrefabToSpawn, randomPosition, Quaternion.identity);
        go.destination = destination;
        go.timer = 0f;
        go.gameObject.transform.parent = Main.EnemyMain.enemiesKeeper;
        Main.EnemyMain.enemies.Add(go);
    }

    private void GetEnemyFromPool(Vector3 randomPosition, Vector3 destination)
    {
        EnemyContent go = Main.EnemyMain.enemyPooling.GetFromPool();
        go.gameObject.transform.position = randomPosition;
        go.destination = destination;
        go.timer = 0f;
    }
}
