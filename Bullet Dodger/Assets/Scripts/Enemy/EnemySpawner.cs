using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private void Awake()
    {
        Main.EnemyMain.init += StartToSpawnEnemies;
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

            if (Main.EnemyMain.enemiesPool.Count != 0)
            {
                EnemyContent go = Main.EnemyMain.enemyPooling.DequeueEnemy();
                go.gameObject.transform.position = randomPosition;
                go.destination = destination;
                go.timer = 0f;

            }
            else
            {
                EnemyContent go = Instantiate(Main.EnemyMain.refs.enemyPrefabToSpawn, randomPosition, Quaternion.identity);
                go.destination = destination;
                go.timer = 0f;
                Main.EnemyMain.enemies.Add(go);
                
            }
            
            

        }
    }
}
