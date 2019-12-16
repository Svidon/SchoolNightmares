using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorsController : MonoBehaviour
{
    // References to teacher
    public GameObject teacherObject;
    private TeacherController teacherScript;

    // UI elements
    public GameObject scissorsTooltip;
    public GameObject itemUI;

    void Start(){
        teacherScript = teacherObject.GetComponent<TeacherController>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player")) {
            print("Got Scissors");

            other.gameObject.GetComponent<BoyScissorsController>().hasScissors = true;

            // Show the tooltip
            scissorsTooltip.SetActive(true);

            // Insert the scissor in the item box
            itemUI.SetActive(true);

            // Freeze the game so the player can read the box
            WorldControl.FreezeGame();

            // Make the teacher run after the player
            teacherScript.StartFollowing();

            // Deactivate/Destroy this object
            Destroy(gameObject);
            Destroy(GameObject.Find("Arrow_scissor"));
        }
    }
}
