using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadleController : MonoBehaviour
{
    public GameObject itemUI;

    void OnTriggerEnter2D(Collider2D other) {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player")) {
            print("Got Ladle");

            other.gameObject.GetComponent<BoyLadleController>().hasLadle = true; // change it

            // Insert the scissor in the item box
            itemUI.SetActive(true);

            // Deactivate/Destroy this object
            Destroy(gameObject);
            Destroy(GameObject.Find("Arrow_ladle"));
        }
    }
}
