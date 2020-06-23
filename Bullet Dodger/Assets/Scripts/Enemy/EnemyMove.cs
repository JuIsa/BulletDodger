using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private bool isGameOver = false;

    private void Awake() => Main.EnemyMain.onGameOver += ChangeBool;

    private void ChangeBool()
    {
        isGameOver = true;
    }

    private void Update()
    {
        if (!isGameOver)
        {
            MoveEnemies();
            IncreaseTimerOfEnemies();
        }
    }

    private  void MoveEnemies()
    {
        for (int i = 0; i < Main.EnemyMain.enemies.Count; i++)
        {
            if (Vector3.Distance(Main.EnemyMain.enemies[i].transform.position, Main.EnemyMain.enemies[i].destination) < .5f)
                Main.EnemyMain.ReachedDestination(Main.EnemyMain.enemies[i]);
            else if(Main.EnemyMain.enemies[i].gameObject.activeSelf)
                Main.EnemyMain.enemies[i].transform.position = Vector3.MoveTowards(Main.EnemyMain.enemies[i].transform.position, Main.EnemyMain.enemies[i].destination, Time.deltaTime);
                
        }
    }

    private  void IncreaseTimerOfEnemies()
    {
        for (int i = 0; i < Main.EnemyMain.enemies.Count; i++)
            if(Main.EnemyMain.enemies[i].gameObject.activeSelf)
                Main.EnemyMain.enemies[i].timer += Time.deltaTime;
    }
}
