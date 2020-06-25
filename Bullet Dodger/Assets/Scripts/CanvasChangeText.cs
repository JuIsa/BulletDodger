using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasChangeText : MonoBehaviour
{
    public Text text;
    public Text x;
    public Text z;
    public GameObject restart;
    public GameObject BTN;
    public GameObject joystick;
    private int seconds;
    private bool isGameOver = false;
    private void Start()
    {
        StartCoroutine(ChangeValue());
        seconds = 0;
        Main.EnemyMain.onGameOver += GameOver;
    }

    private void FixedUpdate()
    {
       // x.text = Main.EnemyMain.player.gameObject.transform.position.x.ToString();
        //z.text = Main.EnemyMain.player.gameObject.transform.position.z.ToString();
    }

    private void GameOver()
    {
        joystick.SetActive(false);
        BTN.SetActive(true);
        restart.SetActive(true);
        isGameOver = true;
    }

    private IEnumerator ChangeValue()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            if(!isGameOver)
                seconds++;
            text.text = seconds.ToString();
        }
    }
}
