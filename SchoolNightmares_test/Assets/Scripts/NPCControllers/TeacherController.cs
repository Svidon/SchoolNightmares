using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherController : MonoBehaviour
{
    private static bool following;
    private Vector2 direction;
    private Vector2 movement;
    private float speed;
    
    // Reference to teacher object and its rigidbody
    public GameObject teacher;
    private Rigidbody2D rb;

    // Reference to player
    public Transform player;

    void Start(){
        following = false;
        rb = this.GetComponent<Rigidbody2D>();
        speed = 1.2f;
    }

    void Update(){

        // Follow the player if it has to
        if(following){
            // Compute direction to go to
            direction = player.position - transform.position;
            direction.Normalize();
            movement = direction;
        }

    }

    // To perform the movement at the end of the computations
    void FixedUpdate(){
        if(following){
            // Now move the character
            rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
        }
    }

    // Make the teacher follow the player
    public static void StartFollowing(){
        print("Started moving towards player");

        following = true;
    }
}
