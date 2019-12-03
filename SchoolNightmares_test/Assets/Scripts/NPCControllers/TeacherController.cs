using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Pathfinding;

public class TeacherController : MonoBehaviour
{
    private bool following;
    
    void Start(){
        following = false;
    }

    // Make the teacher follow the player
    public void StartFollowing(){
        print("Started moving towards player");

        // Activate destination detection for path computing
        gameObject.GetComponent<AIDestinationSetter>().enabled = true;

        // Set following to true so then we can restart the level
        following = true;
    }

    // Called when the teacher reaches the player
    void OnTriggerEnter2D(Collider2D other) {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player") && following) {
            print("Got by teacher");
            this.CancelInvoke("UpdatePath");
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        }
    }
}
