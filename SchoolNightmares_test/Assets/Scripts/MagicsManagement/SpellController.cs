using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellController : MonoBehaviour
{
    // Arrays of spells
    [SerializeField] public Spell[] allSpells;
    [SerializeField] public Spell[] playerSpells;
    public static Spell[] activeSpells;
    public static Spell[] everySpell;

    // Reference to the player
    //public GameObject player;

    // Fire point of the character
    public Transform firePoint;
    public GameObject fireballPrefab;


    void Start(){

        // Add a spell to the player
        // In position 0 there will be spell 9

        playerSpells[1].name = "Not learned";
        playerSpells[1].description = "Not learned";

        playerSpells[2].name = "Not learned";
        playerSpells[2].description = "Not learned";

        playerSpells[3].name = "Not learned";
        playerSpells[3].description = "Not learned";

        playerSpells[4].name = "Not learned";
        playerSpells[4].description = "Not learned";

        playerSpells[5].name = "Not learned";
        playerSpells[5].description = "Not learned";

        playerSpells[6].name = "Not learned";
        playerSpells[6].description = "Not learned";

        playerSpells[7].name = "Not learned";
        playerSpells[7].description = "Not learned";

        playerSpells[8].name = "Not learned";
        playerSpells[8].description = "Not learned";

        playerSpells[0].name = "Not learned";
        playerSpells[0].description = "Not learned";

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
            CastSpell(playerSpells[5]);
        } else if (Input.GetKeyDown("6") && playerSpells[6].learned == true){
            CastSpell(playerSpells[6]);
        } else if (Input.GetKeyDown("7") && playerSpells[7].learned == true){
            CastSpell(playerSpells[7]);
        } else if (Input.GetKeyDown("8") && playerSpells[8].learned == true){
            CastSpell(playerSpells[8]);
        } else if (Input.GetKeyDown("9") && playerSpells[0].learned == true){
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
            case 6:
                print("Casted Spell 6");
                break;
            case 7:
                print("Casted Spell 7");
                break;
            case 8:
                print("Casted Spell 8");
                break;
            case 9:
                print("Casted Spell 9");
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
