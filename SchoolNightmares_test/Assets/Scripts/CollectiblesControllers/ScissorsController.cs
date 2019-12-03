using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorsController : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other) {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player")) {
            print("Got Scissors");

            BoyMovement.hasScissors = true;

            // Make the teacher run after the player
            //TeacherController.StartFollowing();
            AITeacher.StartFollowing();

            // Deactivate/Destroy this object
            Destroy(gameObject);
        }
    }
}
