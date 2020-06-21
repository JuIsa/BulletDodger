using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPooling : MonoBehaviour
{
    private void Awake()
    {
        Main.EnemyMain.onEnemyReachedDestination += EnqueueEnemy;
    }

    private void EnqueueEnemy(EnemyContent enemy, Vector3 destination)
    {
        Main.EnemyMain.enemiesPool.Enqueue(enemy);
        enemy.gameObject.SetActive(false);
    }

    public EnemyContent DequeueEnemy() 
    {
        EnemyContent enemy = (EnemyContent)Main.EnemyMain.enemiesPool.Dequeue();
        enemy.gameObject.SetActive(true);
        return enemy;
    }

   


}
