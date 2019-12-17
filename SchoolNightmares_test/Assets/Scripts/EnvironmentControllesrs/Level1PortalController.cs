using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1PortalController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player"))
        {
            // Move to the next level
            SceneManager.LoadScene("Level2", LoadSceneMode.Single);
        }
    }
}
