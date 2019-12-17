using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostboltScriptController : MonoBehaviour
{
    public GameObject scrollTooltip;

    void OnTriggerEnter2D(Collider2D other) {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player")) {
            print("Got Scroll");

            SpellController.LearnSpell(3);

            // Show the tooltip
            scrollTooltip.SetActive(true);

            // Deactivate/Destroy this object
            Destroy(gameObject);
        }
    }
}
