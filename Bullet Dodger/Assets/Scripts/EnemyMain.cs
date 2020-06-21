using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyMain : MonoBehaviour
{
    public EnemyRef refs;
    public event Action init;

    public GlobalRefs globalRefs;


    public List<EnemyContent> enemies = new List<EnemyContent>();
    public List<Vector3> destinations = new List<Vector3>();
    
    private void Start()
    {
        init?.Invoke();
        Debug.Log("Event Stated");
    }
}
