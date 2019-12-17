using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionariesController : MonoBehaviour
{
    public GameObject itemUI;

    void OnTriggerEnter2D(Collider2D other) {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player")) {
            print("Got Dictionaries!");

            other.gameObject.GetComponent<BoyDictionariesController>().hasDictionaries = true; // change it

            // Insert the scissor in the item box
            itemUI.SetActive(true);

            // Deactivate/Destroy this object
            Destroy(gameObject);
        }
    }
}
