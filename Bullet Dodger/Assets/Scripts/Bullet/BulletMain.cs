using UnityEngine;
using System;
using System.Collections.Generic;

public class BulletMain : MonoBehaviour
{
    public BulletSpawner bulletSpawn;
    public BulletRefs bulletRef;

    public event Action onBulletShot;
    public event Action<BulletContent> onBulletSpawned;

    public List<BulletContent> bullets;
    public void BulletShoot()
    {
        onBulletShot?.Invoke();
        Debug.Log("Shot");
    }

    public void BulletSpawned(BulletContent bullet)
    {
        onBulletSpawned?.Invoke(bullet);
    }
}
