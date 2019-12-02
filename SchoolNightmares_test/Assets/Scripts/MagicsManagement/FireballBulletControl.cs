using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballBulletControl : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody2D rb;
    public Transform player;


    // Start is called before the first frame update
    void Start() {

        // Get rigidbody component
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }


    void OnTriggerEnter2D(Collider2D other){

        print(other.name);
        // Just if it hits the ice destroy the other object
        if(other.name == "ice_block"){
            print("Hit ice block");
            Destroy(other.gameObject);
        }

        Destroy(gameObject);
    }
}
