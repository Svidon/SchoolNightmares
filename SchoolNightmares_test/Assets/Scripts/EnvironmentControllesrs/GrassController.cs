using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassController : MonoBehaviour
{
    public GameObject grassTooltip;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player"))
        {

            // Show tooltip
            grassTooltip.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player"))
        {

            // Show tooltip
            grassTooltip.SetActive(false);
        }
    }
}
