using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorsController : MonoBehaviour
{
    public GameObject scissors;

    void OnTriggerEnter2D(Collider2D other) {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player")) {
            print("Got Scissors");

            // Make the teacher run after the player
            TeacherController.StartFollowing();

            // Deactivate/Destroy this object
            //scissors.SetActive(false);
            Destroy(scissors);
        }
    }
}
