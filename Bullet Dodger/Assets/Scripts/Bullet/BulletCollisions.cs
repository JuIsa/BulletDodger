using UnityEngine;
using System.Collections;
using System;

public class BulletCollisions : MonoBehaviour
{
    private void Awake()
    {
        Main.BulletMain.onBulletSpawned += AddCatcherToBullet;
    }

    private void AddCatcherToBullet(BulletContent bullet)
    {
        bullet.collisionCatcher.OnCollisionEnterEvent += collis => BulletCollected(collis, bullet);
    }

    private void BulletCollected(Collision other, BulletContent bullet)
    {
        if (other.gameObject.CompareTag("Wall"))
            Main.BulletMain.BulletHitWall(bullet);
        else if (other.gameObject.CompareTag("Player"))
            Main.EnemyMain.GameOver();
        else
            bullet.gameObject.SetActive(false);
    }
}
