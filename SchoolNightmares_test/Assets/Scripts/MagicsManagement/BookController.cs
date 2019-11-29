using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class BookController : MonoBehaviour
{
    public Spell[] spells;
    public GameObject spellbook;

    // OnEnable is called once when the object is enabled
    void OnEnable() {
        // Do the same as it was just started
        spells = SpellController.activeSpells;

        for (int i=0; i<9; i++){
            if(spells[i].learned == true){
                // Access right child of spellbook and its properties to set
                 GameObject spellObject = spellbook.transform.GetChild(i).gameObject;
                 GameObject spellDescription = spellObject.transform.GetChild(0).gameObject;
                 GameObject spellName = spellObject.transform.GetChild(1).gameObject;

                 // Set the properties
                 spellObject.GetComponent<UnityEngine.UI.Image>().sprite = spells[i].icon;
                 spellDescription.GetComponent<UnityEngine.UI.Text>().text = spells[i].description.ToString();
                 spellName.GetComponent<TextMeshProUGUI>().text = spells[i].name.ToString();
            } else{
                // Access right child of spellbook and its properties to set
                 GameObject spellObject = spellbook.transform.GetChild(i).gameObject;
                 GameObject spellDescription = spellObject.transform.GetChild(0).gameObject;
                 GameObject spellName = spellObject.transform.GetChild(1).gameObject;

                 // Set the "Not Learned" text
                 spellDescription.GetComponent<UnityEngine.UI.Text>().text = spells[i].description.ToString();
                 spellName.GetComponent<TextMeshProUGUI>().text = spells[i].name.ToString();
            }

        }
    }

}
