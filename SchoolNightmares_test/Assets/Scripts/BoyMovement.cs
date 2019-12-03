using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;
    [SerializeField] private float moveSpeed = 1.0f;



    // Here just for the moment
    public static bool hasScissors = false;
    private float timeBtwAttack;
    public float startTimeBtwAttack;
    public Transform attackPosition;
    public float attackRange;
    public LayerMask whatIsWeed;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        moveH = Input.GetAxis("Horizontal") * moveSpeed;
        moveV = Input.GetAxis("Vertical") * moveSpeed;
        rb.velocity = new Vector2(moveH, moveV);

        Vector2 direction = new Vector2(moveH, moveV);
        FindObjectOfType<BoyAnimation>().SetDirection(direction);

    }


    // For the moment it'll just be here
    private void Update(){

        if (timeBtwAttack <= 0){

            if (Input.GetKeyDown("q") && hasScissors){
                print("Cutting with scissors");

                // Generate the circle to hit the weed
                Collider2D[] weeds = Physics2D.OverlapCircleAll(attackPosition.position, attackRange, whatIsWeed);

                for(int i=0; i< weeds.Length; i++){
                    Destroy(weeds[i].gameObject);
                }
            }
        } else {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPosition.position, attackRange);
    }
}
