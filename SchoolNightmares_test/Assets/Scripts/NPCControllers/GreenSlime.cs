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


    void Start() {
        changeTime = startChangeTime;
        randomSpot = Random.Range(0, spots.Length);
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

    }


    void OnTriggerEnter2D(Collider2D other) {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player"))
        {
            print("Player caught!");

            // Restart level
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        
        // Change the path point if it collides with rocks
        if (!other.gameObject.CompareTag("Player")) {
            randomSpot = Random.Range(0, spots.Length);
            changeTime = startChangeTime;
        }
    }
}
