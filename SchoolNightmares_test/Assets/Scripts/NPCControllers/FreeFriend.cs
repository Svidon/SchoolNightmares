using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeFriend : MonoBehaviour
{
    public GameObject dialogue;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player"))
        {
            print("Friend is free - remove stone");

            // Show dialogue
            dialogue.SetActive(true);

            // Deactivate/Destroy this object
            Destroy(GameObject.Find("TemperaryStone"));
        }
    }
}
