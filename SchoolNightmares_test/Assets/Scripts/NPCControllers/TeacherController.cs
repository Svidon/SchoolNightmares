using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Pathfinding;

public class TeacherController : MonoBehaviour
{
    private bool following;
    public GameObject dialogueBefore;
    public GameObject dialogueAfter;

    // Control variable checking if the level has to be reloaded
    private bool caught;
    
    void Start(){
        following = false;
        caught = false;
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
            this.CancelInvoke("UpdatePath"); // To make sure Astar stops computing paths

            // Show dialogue and freeze game
            dialogueAfter.SetActive(true);
            WorldControl.FreezeGame();

            // Set caught to true so the next scene can be loaded
            caught = true;
        } else if (other.CompareTag("Player")){
            // Dialogue interaction
            dialogueBefore.SetActive(true);
        }
    }

    void Update(){
        // Check if player was caught then restart scene
        if(caught){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        }
    }
}
