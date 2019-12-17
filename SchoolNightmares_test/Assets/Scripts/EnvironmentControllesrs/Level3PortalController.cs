using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3PortalController : MonoBehaviour
{
    // Checks whether the friend is freed
    public static bool freedFriend = false;

    // Tooltip
    public GameObject notFreedTooltip;

    void Start(){
        freedFriend = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player") && freedFriend)
        {
            // Move to the next level
            SceneManager.LoadScene("Endscreen", LoadSceneMode.Single);
        } else if (other.CompareTag("Player")){
            // Show tooltip
            notFreedTooltip.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if (other.CompareTag("Player")){
            // Hide tooltip
            notFreedTooltip.SetActive(false);
        }
    }
}
