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
            for(int i = 0; i < Main.BulletMain.bullets.Count; i++)
            {
                var step = 2 * Time.deltaTime;
                var position = Main.BulletMain.bullets[i].gameObject.transform.forward*Time.deltaTime;
                Main.BulletMain.bullets[i].rb.AddForce(Main.BulletMain.bullets[i].gameObject.transform.forward);

                //Main.BulletMain.bullets[i].rb.velocity = Main.BulletMain.bullets[i].gameObject.transform.forward * Time.deltaTime * 2;
                //Main.BulletMain.bullets[i].gameObject.transform.position += Main.BulletMain.bullets[i].gameObject.transform.forward * Time.deltaTime * 2;
            }
            yield return null;
        }
    }
}
