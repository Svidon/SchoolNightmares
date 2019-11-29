using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellController : MonoBehaviour
{
    // Arrays of spells
    public Spell[] allSpells;
    public Spell[] playerSpells;
    public static Spell[] activeSpells;


    void Start(){

        // Add a spell to the player
        // In position 0 there will be spell 9

        playerSpells[1].id = allSpells[1].id;
        playerSpells[1].name = allSpells[1].name;
        playerSpells[1].icon = allSpells[1].icon;
        playerSpells[1].description = allSpells[1].description;
        playerSpells[1].learned = true;

        playerSpells[2].id = allSpells[2].id;
        playerSpells[2].name = allSpells[2].name;
        playerSpells[2].icon = allSpells[2].icon;
        playerSpells[2].description = allSpells[2].description;
        playerSpells[2].learned = true;

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
    }


    void Update(){

        // Check if a spell was casted
        if (Input.GetKeyDown("1")){
            CastSpell(playerSpells[1]);
        } else if (Input.GetKeyDown("2")){
            CastSpell(playerSpells[2]);
        } else if (Input.GetKeyDown("3")){
            CastSpell(playerSpells[3]);
        } else if (Input.GetKeyDown("4")){
            CastSpell(playerSpells[4]);
        } else if (Input.GetKeyDown("5")){
            CastSpell(playerSpells[5]);
        } else if (Input.GetKeyDown("6")){
            CastSpell(playerSpells[6]);
        } else if (Input.GetKeyDown("7")){
            CastSpell(playerSpells[7]);
        } else if (Input.GetKeyDown("8")){
            CastSpell(playerSpells[8]);
        } else if (Input.GetKeyDown("9")){
            CastSpell(playerSpells[0]);
        }
    }


    private void CastSpell(Spell s){
        switch(s.id){
            case 1:
                print("Casted Spell" + s.name);
                break;
            case 2:
                print("Casted Spell 2");
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

}
