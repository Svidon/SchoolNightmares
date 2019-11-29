using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public GameObject p;
    void OnTriggerEnter2D(Collider2D other)
    {
        

        if (other.CompareTag("Player"))
        {
            //p = GameObject.Find("Player");
            //p.transform.position = new Vector2(12.15f, -9.39f);
            p.transform.position = new Vector2(-13f, 11f);
        }

    }
}
