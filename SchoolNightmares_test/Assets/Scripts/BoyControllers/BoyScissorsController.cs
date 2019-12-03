using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyScissorsController : MonoBehaviour
{
    // Control to check if player has the item
    public bool hasScissors = false;

    // Set a time delay for consecutive attacks
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    // Position and range of the attack
    public Transform attackPosition;
    public float attackRange;

    // Layer mask to identify objectives
    public LayerMask whatIsWeed;


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

    // Draws useful gizmos around attacking area
    void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPosition.position, attackRange);
    }
}
