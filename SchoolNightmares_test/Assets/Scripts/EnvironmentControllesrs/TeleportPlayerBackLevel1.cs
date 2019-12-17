using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayerBackLevel1 : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            // Move the player
            other.gameObject.transform.position = new Vector2(15.5f, -6f);
        }

    }
}
