using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Pathfinding;

public class AITeacher : MonoBehaviour
{
    public Transform player;
    public float speed = 1.5f;
    public float maxDistance = 0.2f;

    // Needed for the pathfinding
    public float nextWaypointDistance = 1f;
    private Path path;
    private int currentWaypoint = 0;
    private bool reachedEndOfPath = false;

    // Control to start the teacher movement
    private static bool following = false;

    private Seeker seeker;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        // Get the components
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        // Setup path "continuous" refreshing
        InvokeRepeating("UpdatePath", 0f, 0.5f);
    }

    // FixedUpdate is called a fixed amount of times per second
    void FixedUpdate() {

        if(path == null){
            return;
        }

        // Check if the teacher has to move
        if (following){
            // Check if we reached the end of path
            // Else is needed to restart again if the player moves away
            if (currentWaypoint >= path.vectorPath.Count){
                reachedEndOfPath = true;
                return;
            }else if (path != null){
                reachedEndOfPath = false;
            }

            // Get the direction to follow for the next waypoint
            // Also normalize error into [-1, 1]
            Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).normalized;
            //Vector2 force = direction * speed * Time.deltaTime;

            // Now we can move with the parameters we have
            // Check if the player is too close to move
            if(((Vector2)path.vectorPath[currentWaypoint] - rb.position).magnitude > maxDistance) {
                rb.MovePosition((Vector2)rb.position + (direction * speed * Time.deltaTime));
                print("direction" + direction);
                //rb.AddForce(force);
            }

            // Compute distance to the waypoint
            float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);
            // If the player is close enough move to the next waypoint
            if (distance < nextWaypointDistance){
                currentWaypoint++;
            }
        }
    }

    // Make the teacher follow the player
    public static void StartFollowing(){
        print("Started moving towards player");

        following = true;
    }

    void UpdatePath(){
        
        // Check if the previous computations have finished
        if(seeker.IsDone()){
            // Now compute the path (last attribute is the function to call when the computing is done)
            seeker.StartPath(rb.position, player.position, OnPathComplete);
        }
    }

    // To call when the path computation is done
    void OnPathComplete(Path p){
        if (!p.error){
            path = p;
            currentWaypoint = 0;
        }
    }


    // Called when the teacher reaches the player
    void OnTriggerEnter2D(Collider2D other) {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player") && following) {
            print("Got by teacher");
            this.CancelInvoke("UpdatePath");
            SceneManager.LoadScene("Level1", LoadSceneMode.Additive);
        }
    }
    
}
