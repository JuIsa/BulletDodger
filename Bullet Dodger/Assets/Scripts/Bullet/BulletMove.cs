using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour
{

    private void Awake()
    {
        Main.BulletMain.onBulletShot += StartMovingBullets;
    }

    private void StartMovingBullets()
    {
        Debug.Log("Received");
        Main.BulletMain.onBulletShot -= StartMovingBullets;
        StartCoroutine(corMoveBullets());
    }

    private IEnumerator corMoveBullets()
    {
        while (true)
        {
            for (int i = 0; i < Main.BulletMain.bullets.Count; i++)
                if (Main.BulletMain.bullets[i].gameObject.activeSelf)
                    MoveBullet(Main.BulletMain.bullets[i]);
            yield return null;
        }
    }

    private void MoveBullet(BulletContent bullet)
    {
        var step = 2 * Time.deltaTime;
        var position = bullet.gameObject.transform.forward * Time.deltaTime;
        bullet.rb.AddForce(bullet.gameObject.transform.forward);
    }
}
