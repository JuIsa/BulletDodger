using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPooling : MonoBehaviour
{
    private void Awake()
    {
        Main.BulletMain.onBulletHitWall += AddToPool;
    }

    private void AddToPool(BulletContent bullet)
    {
        bullet.rb.velocity = Vector3.zero;
        bullet.gameObject.transform.position = UtilityCustom.GetRandomPosition();
        Main.BulletMain.bulletsPool.Enqueue(bullet);
        bullet.gameObject.SetActive(false);
    }

    public BulletContent GetFromPool()
    {
        BulletContent bullet = Main.BulletMain.bulletsPool.Dequeue();
        bullet.gameObject.SetActive(true);
        return bullet;
    }
}
