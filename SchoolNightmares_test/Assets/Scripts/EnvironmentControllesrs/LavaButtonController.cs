using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaButtonController : MonoBehaviour
{

    public GameObject buttonTooltip;

    // Reference to the bridge and lava tiles to deactivate
    public GameObject bridge;
    public GameObject[] lavas;
    public GameObject bridgeDialogue;

    // Checks if already used
    // We don't want to use it more times
    private bool used = false;

    void Start(){
        used = false;
    }

    void OnTriggerEnter2D(Collider2D other) {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player") && !used)
        {
            // Show the tooltip
            buttonTooltip.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        
        // Check that the triggering object is the player
        if (other.CompareTag("Player"))
        {
            // Hide the tooltip
            buttonTooltip.SetActive(false);
        }
    }

    public void UnlockBridge(){
        if(!used){
            for(int i=0; i<lavas.Length; i++){
                lavas[i].SetActive(false);
            }
            bridge.SetActive(true);
            bridgeDialogue.SetActive(true);
            used = true;
        }
    }
}
