using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    [SerializeField] private float speed;//.007 optimal
    private Touch _touch;
    private bool isGameOver = false;
    void Start()
    {
        RayManager.StartRays();
        Main.EnemyMain.onGameOver += ChangeBool;
    }

    private void ChangeBool()
    {
        isGameOver = true;
    }

    void FixedUpdate()
    {
        
        if (Input.touchCount > 0 && !isGameOver) {
            _touch = Input.GetTouch(0);
            if(_touch.phase == TouchPhase.Moved) {
                Main.EnemyMain.player.rb.transform.position = new Vector3(
                    Main.EnemyMain.player.rb.transform.position.x+_touch.deltaPosition.x*speed,
                    Main.EnemyMain.player.rb.transform.position.y,
                    Main.EnemyMain.player.rb.transform.position.z + _touch.deltaPosition.y * speed);
            }
        }
        

       
        //Vector3 move = new Vector3(SimpleInput.GetAxis("Horizontal") * speed, 0, SimpleInput.GetAxis("Vertical") * speed);
        //Main.EnemyMain.player.rb.velocity = move;
    }

    
}
