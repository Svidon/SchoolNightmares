using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyDictionariesController : MonoBehaviour
{
    // Control to check if player has the item
    public bool hasDictionaries = false;

    // Set a time delay for consecutive attacks
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    // Position and range of the attack
    public Transform attackPosition;
    public float attackRange;

    // Layer mask to identify objectives
    public LayerMask whatIsButton;

    void Start(){
        hasDictionaries = false;
    }

    private void Update(){

        if (timeBtwAttack <= 0){

            if (Input.GetKeyDown("q") && hasDictionaries){
                print("Cutting with scissors");

                // Generate the circle to hit the weed
                Collider2D[] btn = Physics2D.OverlapCircleAll(attackPosition.position, attackRange, whatIsButton);

                for(int i=0; i< btn.Length; i++){
                    btn[i].gameObject.GetComponent<LavaButtonController>().UnlockBridge();
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
