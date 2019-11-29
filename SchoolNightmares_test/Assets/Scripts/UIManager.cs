using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject spellbook;

    // Variable to check if the spellbook has to be seen
    private static bool spellBookVisible = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){

        // Show/hide spellbook if you press 'p'
        // Hide the spellbook even if we press 'escape'
        if (Input.GetKeyDown("p") && GetSpellBookVisible() == false){
            spellbook.SetActive(true);
            SetSpellBookVisible(true);
        } else if ((Input.GetKeyDown("escape") || Input.GetKeyDown("p")) && GetSpellBookVisible() == true){
            spellbook.SetActive(false);
            SetSpellBookVisible(false);
        }
        
    }



    // Getter and setter for 'spellBookVisible'
    public static bool GetSpellBookVisible(){
        return spellBookVisible;
    }
    public static void SetSpellBookVisible(bool b){
        spellBookVisible = b;
    }
}
