﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayerBackLevel1 : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            //p = GameObject.Find("Player");
            //p.transform.position = new Vector2(19.5f, 8.03f); //correct witch
            other.gameObject.transform.position = new Vector2(15.5f, -6f);
        }

    }
}