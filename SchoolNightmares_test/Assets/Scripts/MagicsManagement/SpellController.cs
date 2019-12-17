using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellController : MonoBehaviour
{
    // Arrays of spells
    public Spell[] allSpells; // Contains all the spells definitions from inspector
    public Spell[] playerSpells; // Contains the actual player spells
    public static Spell[] activeSpells; // Support array to learn spells
    public static Spell[] everySpell; // Support array to assign new learned spells

    // Spells Cooldowns
    private float[] fixedCooldowns;

    // Fire point of the character
    public Transform firePoint;

    // Prefabs for the spells
    public GameObject fireballPrefab;
    public GameObject greedyIllusionPrefab;
    public GameObject frostboltPrefab;


    void Start(){

        // Add a spell to the player
        // In position 0 there will be spell 5
        // This sets learned spells in previous levels
        for (int i=1; i<4; i++){
            if(allSpells[i].learned){
                playerSpells[i].id = allSpells[i].id;
                playerSpells[i].name = allSpells[i].name;
                playerSpells[i].icon = allSpells[i].icon;
                playerSpells[i].description = allSpells[i].description;
                playerSpells[i].cooldown = allSpells[i].cooldown;
                playerSpells[i].learned = true;
            } else {
                playerSpells[i].name = "Not learned";
                playerSpells[i].description = "Not learned";
                playerSpells[i].id = allSpells[1].id;
                playerSpells[i].cooldown = 100;
            }
        }

        // This slot will never be used
        playerSpells[0].name = "Not learned";
        playerSpells[0].description = "Not learned";
        playerSpells[0].id = allSpells[0].id;
        playerSpells[0].cooldown = 100;

        activeSpells = playerSpells;
        everySpell = allSpells;

        // Setup the cooldowns
        fixedCooldowns = new float[5];
        fixedCooldowns[0] = 0;
        fixedCooldowns[1] = 0;
        fixedCooldowns[2] = 0;
        fixedCooldowns[3] = 0;
        fixedCooldowns[4] = 0;
    }

    void Update(){

        // Update the player spells with the static array
        playerSpells = activeSpells;

        // Check if a spell was casted
        if (Input.GetKeyDown("1") && (playerSpells[1].learned == true) && (fixedCooldowns[1] <= 0)){
            fixedCooldowns[1] = playerSpells[1].cooldown;
            CastSpell(playerSpells[1]);
        } else if (Input.GetKeyDown("2") && (playerSpells[2].learned == true) && (fixedCooldowns[2] <= 0)){
            fixedCooldowns[2] = playerSpells[2].cooldown;
            CastSpell(playerSpells[2]);
        } else if (Input.GetKeyDown("3") && (playerSpells[3].learned == true) && (fixedCooldowns[3] <= 0)){
            fixedCooldowns[3] = playerSpells[3].cooldown;
            CastSpell(playerSpells[3]);
        }

        // Update the cooldowns
        for(int i=0; i<5; i++){
            fixedCooldowns[i] -= Time.deltaTime;
        }
    }


    // Inserts a new spell in the player's spellbook
    public static void LearnSpell(int i){
        activeSpells[i].id = everySpell[i].id;
        activeSpells[i].name = everySpell[i].name;
        activeSpells[i].icon = everySpell[i].icon;
        activeSpells[i].description = everySpell[i].description;
        activeSpells[i].cooldown = everySpell[i].cooldown;
        activeSpells[i].learned = true;
    }


    private void CastSpell(Spell s){
        switch(s.id){
            case 1:
                // Cast a fireball
                Fireball();
                break;
            case 2:
                GreedyIllusion();
                break;
            case 3:
                Frostbolt();
                break;
            default:
                print("Spell casting ERROR!");
                break;
        }
    }

    
    /* FOLLOWING THIS THERE WILL BE ALL THE SPELL CODES, IN ID ORDER */
    // Cast a fireball using prefabs
    private void Fireball(){
        Instantiate(fireballPrefab, firePoint.position, firePoint.rotation);
    }

    private void GreedyIllusion(){
        Instantiate(greedyIllusionPrefab, firePoint.position, firePoint.rotation);
    }

    private void Frostbolt(){
        Instantiate(frostboltPrefab, firePoint.position, firePoint.rotation);
    }

}
