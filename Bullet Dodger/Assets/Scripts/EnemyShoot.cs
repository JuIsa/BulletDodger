﻿using UnityEngine;
using System.Collections;
using System;

public class EnemyShoot : MonoBehaviour
{

    private void Awake()
    {
        Main.EnemyMain.init += StartShooting;
    }

    private void StartShooting()
    {
        StartCoroutine(corStartShooting());
    }

    private IEnumerator corStartShooting()
    {
        while (true)
        {
            
            for(int i = 0; i < Main.EnemyMain.enemies.Count; i++)
            {
                if (Main.EnemyMain.timers[i] > 1.4f)
                {
                    Main.EnemyMain.timers[i] = 0f;
                    Main.BulletMain.bulletSpawn.SpawnABullet(Main.EnemyMain.enemies[i]);
                }
            }
            yield return null;
        }
    }
}
