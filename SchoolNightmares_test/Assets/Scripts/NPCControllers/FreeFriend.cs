using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

            // The stone is present just in level 1
            if (SceneManager.GetActiveScene().name == "Level1"){
                // Destroy this object
                Destroy(GameObject.Find("TemperaryStone"));
            } else if (SceneManager.GetActiveScene().name == "Level2"){
                // Set the portal control variable to true!
                Level2PortalController.freedFriend = true;
            } else if (SceneManager.GetActiveScene().name == "Level3"){
                // Set the portal control variable to true!
                Level3PortalController.freedFriend = true;
            }
            
        }
    }
}
