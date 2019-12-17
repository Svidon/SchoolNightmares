using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyLadleController : MonoBehaviour
{
    // Control to check if player has the item
    public bool hasLadle = false;

    // Set a time delay for consecutive attacks
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    // Position and range of the attack
    public Transform attackPosition;
    public float attackRange;

    // Layer mask to identify objectives
    public LayerMask whatIsCuldron;

    // Messages to display
    public GameObject eatingTooltip;
    public GameObject finishedTooltip;
    public GameObject oldSuggestionTooltip;

    void Start(){
        hasLadle = false;
    }

    private void Update(){

        if (timeBtwAttack <= 0){

            if (Input.GetKeyDown("q") && hasLadle){
                print("Eating with ladle");

                // Generate the circle to hit the cauldron
                Collider2D[] cauldron = Physics2D.OverlapCircleAll(attackPosition.position, attackRange, whatIsCuldron);

                for(int i=0; i< cauldron.Length; i++){

                    // Destroy the suggestion tooltip
                    oldSuggestionTooltip.SetActive(false);

                    // Get the life of the cauldron
                    int actualLife = cauldron[i].gameObject.GetComponent<CauldronController>().life;
                    
                    // If it has no more life left
                    if(actualLife <= 0){
                        eatingTooltip.SetActive(false); // Close all previous dialogues
                        Destroy(cauldron[i].gameObject); // Destroy the cauldron object
                        finishedTooltip.SetActive(true); // Display finished soup dialogue
                        WorldControl.FreezeGame(); // Freeze the game
                    } else {
                        if (actualLife == 4){
                            eatingTooltip.SetActive(true);
                        } else if(actualLife == 3){
                            eatingTooltip.GetComponentInChildren<UnityEngine.UI.Text>().text = "Come one few ladles more!";
                        } else if (actualLife == 2){
                            eatingTooltip.GetComponentInChildren<UnityEngine.UI.Text>().text = "Almost done with the soup!";
                        } else if (actualLife == 1){
                            eatingTooltip.GetComponentInChildren<UnityEngine.UI.Text>().text = "One last and it's done!";
                        }

                        cauldron[i].gameObject.GetComponent<CauldronController>().life -= 1;
                    }
                    
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
