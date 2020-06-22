using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] EnemyMain enemyMain;
    [SerializeField] BulletMain bulletMain;
    public static EnemyMain EnemyMain => Instance.enemyMain;
    public static BulletMain BulletMain => Instance.bulletMain;

    private static Main _instance;
    

    private static Main Instance
    {
        get
        {
            if (_instance == null)
                _instance = GameObject.FindGameObjectWithTag("Main")?.GetComponent<Main>();
            return _instance;
        }
    }
}
