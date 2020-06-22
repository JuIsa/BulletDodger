using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyMain : MonoBehaviour
{
    public EnemyRef refs;
    public GlobalRefs globalRefs;
    public EnemyPooling enemyPooling;

    public Transform enemiesKeeper;

    public event Action init;
    public event Action<EnemyContent> onEnemyReachedDestination;
    


    public List<EnemyContent> enemies = new List<EnemyContent>();
    public Queue<EnemyContent> enemiesPool = new Queue<EnemyContent>();

    public EnemyContent player;

    

    private void Start()
    {
        init?.Invoke();
        Debug.Log("Event Stated");
    }

    public void ReachedDestination(EnemyContent enemy)
    {
        onEnemyReachedDestination?.Invoke(enemy);
    }
    
}
