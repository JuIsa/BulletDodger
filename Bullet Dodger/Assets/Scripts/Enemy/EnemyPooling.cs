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

    private void EnqueueEnemy(EnemyContent enemy)
    {
        
        enemy.gameObject.transform.position = UtilityCustom.GetRandomPosition();
        enemy.destination = UtilityCustom.GetDestination();
        Main.EnemyMain.enemiesPool.Enqueue(enemy);
        enemy.gameObject.SetActive(false);
    }

    public EnemyContent DequeueEnemy() 
    {
        EnemyContent enemy = Main.EnemyMain.enemiesPool.Dequeue();
        
        enemy.gameObject.SetActive(true);
        return enemy;
    }

   


}
