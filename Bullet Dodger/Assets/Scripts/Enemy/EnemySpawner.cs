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
            EnemyContent go;
            Vector3 destination = UtilityCustom.GetDestination();
            Main.EnemyMain.destinations.Add(destination);
            go = Instantiate(Main.EnemyMain.refs.enemyPrefabToSpawn,randomPosition, Quaternion.identity);
            Main.EnemyMain.enemies.Add(go);
            Main.EnemyMain.timers.Add(0f);
            

        }
    }
}
