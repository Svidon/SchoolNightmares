using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayerLevel3 : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            // Move the player
            other.gameObject.transform.position = new Vector2(-35.5f, -9.2f);
        }

    }
}
