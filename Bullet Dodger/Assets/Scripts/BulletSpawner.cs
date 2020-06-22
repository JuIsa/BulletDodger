using UnityEngine;
using System.Collections;

public class BulletSpawner : MonoBehaviour
{

    public void SpawnABullet(EnemyContent enemy)
    {
        Vector3 positionForBullet = enemy.transform.position+ enemy.transform.forward *.0f;
        BulletContent bullet = Instantiate(Main.BulletMain.bulletRef.bulletToSpawn, positionForBullet, Quaternion.identity);
        bullet.transform.LookAt(Main.EnemyMain.player.transform);
        
        Main.BulletMain.bullets.Add(bullet);

        Main.BulletMain.BulletShoot();
        Main.BulletMain.BulletSpawned(bullet);
    }

}
