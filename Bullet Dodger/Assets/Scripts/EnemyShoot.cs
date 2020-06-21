using UnityEngine;
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
                    Vector3 positionForBullet = Main.EnemyMain.enemies[i].transform.position;
                    GameObject bullet = Instantiate(Main.EnemyMain.refs.bulletPrefab, positionForBullet, Quaternion.identity);
                    bullet.transform.LookAt(Main.EnemyMain.player.transform);
                    Main.EnemyMain.bullets.Add(bullet);
                    Main.EnemyMain.BulletShoot();
                }
            }
            yield return null;
        }
    }
}
