using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDeath : MonoBehaviour
{
    void Start()
    {
        Main.EnemyMain.onGameOver += SpawnParticle;
    }

    private void SpawnParticle()
    {
        Instantiate(Main.EnemyMain.globalRefs.particlePrefab, Main.EnemyMain.player.gameObject.transform.position, Quaternion.identity);
    }
}
