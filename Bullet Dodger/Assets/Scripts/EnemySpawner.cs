using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private void Awake()
    {
        Main.EnemyMain.init += StartToSpawnEnemies;
        Debug.Log("Event is listened");
    }

    private void StartToSpawnEnemies()
    {
        Debug.Log("Actrion acitvcaete");
        StartCoroutine(corSpawnEnemy());
    }

    private IEnumerator corSpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            Vector3 pos = UtilityCustom.GetRandomPosition();
            EnemyContent go = Instantiate(Main.EnemyMain.refs.prefabToSpawn, pos, Quaternion.identity);
            Main.EnemyMain.enemies.Add(go);

            Vector3 destination = UtilityCustom.GetDestination();
            Main.EnemyMain.destinations.Add(destination);
        }
    }
}
