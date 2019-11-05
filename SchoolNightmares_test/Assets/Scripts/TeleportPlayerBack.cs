using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayerBack : MonoBehaviour
{
    public GameObject p;
    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.CompareTag("Player"))
        {
            //p = GameObject.Find("Player");
            //p.transform.position = new Vector2(0.83f, 1.45f);
            p.transform.position = new Vector2(2f, 2f);
        }

    }
}
