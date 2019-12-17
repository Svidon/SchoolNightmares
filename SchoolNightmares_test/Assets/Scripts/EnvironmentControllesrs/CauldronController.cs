using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronController : MonoBehaviour
{
    public GameObject cauldronTooltip;
    public int life = 4;

    void Start(){
        life = 4;
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player"))
        {

            // Show tooltip
            cauldronTooltip.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player"))
        {

            // Hide tooltip
            cauldronTooltip.SetActive(false);
        }
    }
}
