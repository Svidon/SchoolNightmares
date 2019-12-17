using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayerBackLevel2 : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            // Move the player
            other.gameObject.transform.position = new Vector2(11f, -9.9f);
        }

    }
}
