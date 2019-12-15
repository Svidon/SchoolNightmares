using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBlockController : MonoBehaviour
{
    public GameObject iceBlockTooltip;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player"))
        {

            // Show tooltip
            iceBlockTooltip.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player"))
        {

            // Show tooltip
            iceBlockTooltip.SetActive(false);
        }
    }
}
