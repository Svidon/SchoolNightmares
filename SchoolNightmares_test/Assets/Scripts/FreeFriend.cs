using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeFriend : MonoBehaviour
{
    //public GameObject temporaryStone;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        //temporaryStone.name = "Tem";
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player"))
        {
            print("Friend is free - remove stone");

            // Deactivate/Destroy this object
            Destroy(GameObject.Find("TemperaryStone"));
        }
    }
}
