using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScriptController : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other) {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player")) {
            print("Got Scroll");

            SpellController.LearnSpell(2);

            // Deactivate/Destroy this object
            Destroy(gameObject);
        }
    }
}
