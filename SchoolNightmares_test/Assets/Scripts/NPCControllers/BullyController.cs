using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BullyController : MonoBehaviour
{
    // Control variables
    public float startChangeTime;
    private float changeTime;
    public float speed;

    // Spots in which it can move
    public Transform[] spots;
    private int randomSpot;

    // Dialogue when the player is caught
    private bool caught = false;
    public GameObject dialogue;

    // Variables to check if the bully is stunned
    private bool stunned = false;
    private float timeStunned = 0f;

    void Start() {
        changeTime = startChangeTime;
        randomSpot = Random.Range(0, spots.Length);
        caught = false;
        stunned = false;
        timeStunned = 0f;
    }


    // Update is called once per frame
    void Update() {

        // Check whether the Bully is stunned or not
        // If he is stunned freeze the movements, otherwise move as usual
        if (!stunned && timeStunned <= 0){
            // Make the slime move towards the element
            transform.position = Vector2.MoveTowards(transform.position, spots[randomSpot].position, speed * Time.deltaTime);

            // Check if the direction has to be changed
            if(changeTime <= 0){            
                randomSpot = Random.Range(0, spots.Length);
                changeTime = startChangeTime;
            } else {
                changeTime -= Time.deltaTime;
            }
        } else if (stunned && timeStunned > 0){
             timeStunned -= Time.deltaTime; // decrease the time stunned
        } else if (timeStunned <= 0){
            stunned = false;//reset stunned variable
        }

        // Restart level
        if(caught){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        }

    }


    void OnTriggerEnter2D(Collider2D other) {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player"))
        {
            print("Player caught!");

            // Show dialogue and set caught to true to restart the level
            dialogue.SetActive(true);
            WorldControl.FreezeGame();
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        
        // Change the path point if it collides with rocks
        if (!other.gameObject.CompareTag("Player")) {
            randomSpot = Random.Range(0, spots.Length);
            changeTime = startChangeTime;
        }
    }

    // This function is called when he is hit by the coin spell
    public void Stunned(){
        stunned = true;
        timeStunned = 3f;
    }
}
