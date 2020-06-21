using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    private void Update()
    {
        for(int i = 0; i < Main.EnemyMain.enemies.Count; i++)
        {
            Main.EnemyMain.enemies[i].transform.position = Vector3.MoveTowards(Main.EnemyMain.enemies[i].transform.position, Main.EnemyMain.destinations[i], Time.deltaTime);

        }
    }


}
