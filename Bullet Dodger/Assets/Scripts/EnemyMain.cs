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
    
    public event Action init;
    public event Action<EnemyContent, Vector3> onEnemyReachedDestination;
    


    public List<EnemyContent> enemies = new List<EnemyContent>();
    public List<Vector3> destinations = new List<Vector3>();
    public List<float> timers = new List<float>();
    public List<GameObject> bullets = new List<GameObject>();
    public List<Vector3> targets = new List<Vector3>();

    public EnemyContent player;

    public Queue enemiesPool = new Queue();
    public Queue destinationsPool = new Queue();

    private void Start()
    {
        init?.Invoke();
        Debug.Log("Event Stated");
    }

    public void ReachedDestination(EnemyContent enemy, Vector3 destination)
    {
        onEnemyReachedDestination?.Invoke(enemy, destination);
    }
    
}
