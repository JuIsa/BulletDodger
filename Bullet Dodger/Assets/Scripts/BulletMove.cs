using UnityEngine;
using System.Collections;
using System;

public class BulletMove : MonoBehaviour
{

    private void Awake()
    {
        Main.EnemyMain.onBulletShot += StartMovingBullets;
    }

    private void StartMovingBullets()
    {
        Main.EnemyMain.onBulletShot -= StartMovingBullets;
        StartCoroutine(corMoveBullets());
    }

    private IEnumerator corMoveBullets()
    {
        while (true)
        {
            for(int i = 0; i < Main.EnemyMain.bullets.Count; i++)
            {
                
                Main.EnemyMain.bullets[i].transform.position += Main.EnemyMain.bullets[i].transform.forward * Time.deltaTime * 2;
            }
            yield return null;
        }
    }
}
