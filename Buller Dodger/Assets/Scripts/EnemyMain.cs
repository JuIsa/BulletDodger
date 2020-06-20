using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMain : MonoBehaviour
{
    public EnemyRef refs;
    public Action init;


    public List<EnemyContent> enemies = new List<EnemyContent>();
    
    private void Awake()
    {
        init?.Invoke();
    }
}
