﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Touch touch;
    [SerializeField] private float speed;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.touchCount > 0) {
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved) {
                transform.position = new Vector3(
                    transform.position.x+touch.deltaPosition.x*speed,
                    transform.position.y,
                    transform.position.z + touch.deltaPosition.y * speed);
            }
        }
    }
}