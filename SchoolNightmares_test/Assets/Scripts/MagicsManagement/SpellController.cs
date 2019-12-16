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

    // Reference to the player
    //public GameObject player;

    // Fire point of the character
    public Transform firePoint;
    public GameObject fireballPrefab;


    void Start(){

        // Add a spell to the player
        // In position 0 there will be spell 5

        playerSpells[1].name = "Not learned";
        playerSpells[1].description = "Not learned";
        playerSpells[1].id = allSpells[1].id;

        playerSpells[2].name = "Not learned";
        playerSpells[2].description = "Not learned";
        playerSpells[2].id = allSpells[2].id;

        playerSpells[3].name = "Not learned";
        playerSpells[3].description = "Not learned";
        playerSpells[3].id = allSpells[3].id;

        playerSpells[4].name = "Not learned";
        playerSpells[4].description = "Not learned";
        playerSpells[4].id = allSpells[4].id;

        playerSpells[0].name = "Not learned";
        playerSpells[0].description = "Not learned";
        playerSpells[0].id = allSpells[0].id;

        activeSpells = playerSpells;
        everySpell = allSpells;
    }

    void Update(){

        // Update the player spells with the static array
        playerSpells = activeSpells;

        // Check if a spell was casted
        if (Input.GetKeyDown("1") && playerSpells[1].learned == true){
            CastSpell(playerSpells[1]);
        } else if (Input.GetKeyDown("2") && playerSpells[2].learned == true){
            CastSpell(playerSpells[2]);
        } else if (Input.GetKeyDown("3") && playerSpells[3].learned == true){
            CastSpell(playerSpells[3]);
        } else if (Input.GetKeyDown("4") && playerSpells[4].learned == true){
            CastSpell(playerSpells[4]);
        } else if (Input.GetKeyDown("5") && playerSpells[5].learned == true){
            CastSpell(playerSpells[0]);
        }
    }


    // Inserts a new spell in the player's spellbook
    public static void LearnSpell(int i){
        activeSpells[i].id = everySpell[i].id;
        activeSpells[i].name = everySpell[i].name;
        activeSpells[i].icon = everySpell[i].icon;
        activeSpells[i].description = everySpell[i].description;
        activeSpells[i].learned = true;
    }


    private void CastSpell(Spell s){
        switch(s.id){
            case 1:
                // Call fireball code
                print("Casted " + s.name);
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
