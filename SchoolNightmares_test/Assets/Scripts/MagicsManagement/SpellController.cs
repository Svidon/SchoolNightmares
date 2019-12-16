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
    public GameObject fireballPrefab;


    void Start(){

        // Add a spell to the player
        // In position 0 there will be spell 5
        playerSpells[1].name = "Not learned";
        playerSpells[1].description = "Not learned";
        playerSpells[1].id = allSpells[1].id;
        playerSpells[1].cooldown = 100;

        playerSpells[2].name = "Not learned";
        playerSpells[2].description = "Not learned";
        playerSpells[2].id = allSpells[2].id;
        playerSpells[2].cooldown = 100;

        playerSpells[3].name = "Not learned";
        playerSpells[3].description = "Not learned";
        playerSpells[3].id = allSpells[3].id;
        playerSpells[3].cooldown = 100;

        playerSpells[4].name = "Not learned";
        playerSpells[4].description = "Not learned";
        playerSpells[4].id = allSpells[4].id;
        playerSpells[4].cooldown = 100;

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
        } else if (Input.GetKeyDown("4") && (playerSpells[4].learned == true) && (fixedCooldowns[4] <= 0)){
            fixedCooldowns[4] = playerSpells[4].cooldown;
            CastSpell(playerSpells[4]);
        } else if (Input.GetKeyDown("5") && (playerSpells[0].learned == true) && (fixedCooldowns[0] <= 0)){
            fixedCooldowns[0] = playerSpells[0].cooldown;
            CastSpell(playerSpells[0]);
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
                print("Casted Spell 3");
                break;
            case 3:
                print("Casted Spell 3");
                break;
            case 4:
                print("Casted Spell 4");
                break;
            case 5:
                print("Casted Spell 5");
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

}
