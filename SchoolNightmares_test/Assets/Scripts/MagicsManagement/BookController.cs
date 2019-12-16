using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class BookController : MonoBehaviour
{
    private Spell[] spells;
    public GameObject spellController;

    // OnEnable is called once when the object is enabled
    void OnEnable() {
        // Get the player spells
        spells = spellController.GetComponent<SpellController>().playerSpells;
        //spells = SpellController.activeSpells;

        for (int i=1; i<5; i++){
            if(spells[i].learned == true){
                // Access right child of spellbook and its properties to set
                 GameObject spellObject = gameObject.transform.GetChild(i).gameObject;
                 GameObject spellDescription = spellObject.transform.GetChild(0).gameObject;
                 GameObject spellName = spellObject.transform.GetChild(1).gameObject;

                 // Set the properties
                 spellObject.GetComponent<UnityEngine.UI.Image>().sprite = spells[i].icon;
                 spellDescription.GetComponent<UnityEngine.UI.Text>().text = spells[i].description.ToString();
                 spellName.GetComponent<TextMeshProUGUI>().text = spells[i].name.ToString();
            } else{
                // Access right child of spellbook and its properties to set
                 GameObject spellObject = gameObject.transform.GetChild(i).gameObject;
                 GameObject spellDescription = spellObject.transform.GetChild(0).gameObject;
                 GameObject spellName = spellObject.transform.GetChild(1).gameObject;

                 // Set the "Not Learned" text
                 spellDescription.GetComponent<UnityEngine.UI.Text>().text = spells[i].description.ToString();
                 spellName.GetComponent<TextMeshProUGUI>().text = spells[i].name.ToString();
            }

        }

        // Child 5 is handled in a different way (has to go in the last child)
        if(spells[0].learned == true){
            // Access right child of spellbook and its properties to set
                GameObject spellObject = gameObject.transform.GetChild(5).gameObject;
                GameObject spellDescription = spellObject.transform.GetChild(0).gameObject;
                GameObject spellName = spellObject.transform.GetChild(1).gameObject;

                // Set the properties
                spellObject.GetComponent<UnityEngine.UI.Image>().sprite = spells[0].icon;
                spellDescription.GetComponent<UnityEngine.UI.Text>().text = spells[0].description.ToString();
                spellName.GetComponent<TextMeshProUGUI>().text = spells[0].name.ToString();
        } else{
            // Access right child of spellbook and its properties to set
                GameObject spellObject = gameObject.transform.GetChild(5).gameObject;
                GameObject spellDescription = spellObject.transform.GetChild(0).gameObject;
                GameObject spellName = spellObject.transform.GetChild(1).gameObject;

                // Set the "Not Learned" text
                spellDescription.GetComponent<UnityEngine.UI.Text>().text = spells[0].description.ToString();
                spellName.GetComponent<TextMeshProUGUI>().text = spells[0].name.ToString();
        }
    }

}
