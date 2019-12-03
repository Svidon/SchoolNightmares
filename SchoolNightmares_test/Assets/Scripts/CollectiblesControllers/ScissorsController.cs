using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorsController : MonoBehaviour
{
    // References to teacher
    public GameObject teacherObject;
    private TeacherController teacherScript;

    void Start(){
        teacherScript = teacherObject.GetComponent<TeacherController>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player")) {
            print("Got Scissors");

            other.gameObject.GetComponent<BoyScissorsController>().hasScissors = true;

            // Make the teacher run after the player
            teacherScript.StartFollowing();

            // Deactivate/Destroy this object
            Destroy(gameObject);
        }
    }
}
