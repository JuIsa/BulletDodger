using UnityEngine;
using System.Collections;
using System;

public class BulletSpawner : MonoBehaviour
{
    private bool isGameOver = false;

    private void Awake()=> Main.EnemyMain.onGameOver += ChangeBool;
    

    private void ChangeBool()
    {
        isGameOver = true;
    }

    public void SpawnABullet(EnemyContent enemy)
    {
        Vector3 positionForBullet = enemy.transform.position;
        if (!isGameOver)
        {
            if (Main.BulletMain.bulletsPool.Count == 0)
                SpawnNewBullet(positionForBullet);
            else
                GetBulletFromPool(positionForBullet);

            Main.BulletMain.BulletShoot();
        }
    }

    private static void GetBulletFromPool(Vector3 positionForBullet)
    {
        BulletContent bullet = Main.BulletMain.bulletPooling.GetFromPool();
        bullet.transform.position = positionForBullet;
        bullet.transform.LookAt(Main.EnemyMain.player.transform);
    }

    private static void SpawnNewBullet(Vector3 positionForBullet)
    {
        BulletContent bullet = Instantiate(Main.BulletMain.bulletRef.bulletToSpawn, positionForBullet, Quaternion.identity);
        bullet.transform.LookAt(Main.EnemyMain.player.transform);

        bullet.transform.parent = Main.BulletMain.bulletsKeeper;

        Main.BulletMain.bullets.Add(bullet);

        Main.BulletMain.BulletSpawned(bullet);
    }
}
