using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GreenSlime : MonoBehaviour
{
    // Control variables
    public float startChangeTime;
    private float changeTime;
    public float speed;

    // Spots in which it can move
    public Transform[] spots;
    private int randomSpot;

    // Controls variables for when it's hit by the frostbolt
    private bool frozen = false;

    // Checks whether the player was caught
    private bool caught = false;
    public GameObject caughtDialogue;


    void Start() {
        changeTime = startChangeTime;
        randomSpot = Random.Range(0, spots.Length);
        frozen = false;
        caught = false;
    }


    // Update is called once per frame
    void Update() {
        // Make the slime move towards the element
        transform.position = Vector2.MoveTowards(transform.position, spots[randomSpot].position, speed * Time.deltaTime);

        // Check if the direction has to be changed
        if(changeTime <= 0){            
            randomSpot = Random.Range(0, spots.Length);
            changeTime = startChangeTime;
        } else {
            changeTime -= Time.deltaTime;
        }

        // If caught restart the level
        if(caught && !caughtDialogue.gameObject.activeSelf){
            // Restart level
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        }

    }


    void OnTriggerEnter2D(Collider2D other) {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player"))
        {
            print("Player caught!");

            caughtDialogue.SetActive(true);
            WorldControl.FreezeGame();

            caught = true;
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        
        // Change the path point if it collides with rocks
        if (!other.gameObject.CompareTag("Player")) {
            randomSpot = Random.Range(0, spots.Length);
            changeTime = startChangeTime;
        }
    }

    // Function to freeze the slime and make it vulnerable to the fireball
    public void FreezeMonster(){
        // Set frozen true and slow it down
        frozen = true;
        startChangeTime = 3f;
        speed = 2f;

        // Visual change to the rendering
        gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

        // Change gameObject tag so it's vulnerable to the fireball
        gameObject.tag = "IceElement";
    }
}
