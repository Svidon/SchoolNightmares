using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            //p = GameObject.Find("Player");
            //p.transform.position = new Vector2(-13f, 11f); // witch correct
            other.gameObject.transform.position = new Vector2(-24f, -3f);
        }

    }
}
