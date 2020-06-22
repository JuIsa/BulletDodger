using UnityEngine;
using System;
using System.Collections.Generic;

public class BulletMain : MonoBehaviour
{
    public BulletSpawner bulletSpawn;
    public BulletRefs bulletRef;
    public BulletPooling bulletPooling;

    public Transform bulletsKeeper;

    public event Action onBulletShot;
    public event Action<BulletContent> onBulletSpawned;
    public event Action<BulletContent> onBulletHitWall;

    public List<BulletContent> bullets;
    public Queue<BulletContent> bulletsPool = new Queue<BulletContent>();
    public void BulletShoot()
    {
        onBulletShot?.Invoke();
        Debug.Log("Shot");
    }

    public void BulletSpawned(BulletContent bullet)
    {
        onBulletSpawned?.Invoke(bullet);
    }

    public void BulletHitWall(BulletContent bullet)
    {
        onBulletHitWall?.Invoke(bullet);
    }
}
