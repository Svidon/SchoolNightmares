using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject spellbook;
    public GameObject scrollTooltip;

    public GameObject pauseMenu;

    // Variable to check if the spellbook has to be seen
    private static bool spellBookVisible = false;
    private static bool pauseMenuVisible = false;

    // Start is called before the first frame update
    void Start()
    {
        spellBookVisible = false;
        pauseMenuVisible = false;     
    }

    // Update is called once per frame
    void Update(){

        // Show/hide spellbook if you press 'p'
        // Hide the spellbook even if we press 'escape'
        if (Input.GetKeyDown("p") && GetSpellBookVisible() == false){ // pressed "p" to show spellbook
            spellbook.SetActive(true);
            SetSpellBookVisible(true);
            scrollTooltip.SetActive(false);
        } else if(Input.GetKeyDown("escape") && GetPauseMenuVisible() == true){ // "escape" to close pause menu
            pauseMenu.SetActive(false);
            WorldControl.UnFreezeGame();
            SetPauseMenuVisible(false);
        } else if ((Input.GetKeyDown("escape") || Input.GetKeyDown("p")) && GetSpellBookVisible() == true){ // "escape" to close spellbook
            spellbook.SetActive(false);
            SetSpellBookVisible(false);
        } else if (Input.GetKeyDown("escape") && GetPauseMenuVisible() == false){ // "escape" to open pause menu
            pauseMenu.SetActive(true);
            WorldControl.FreezeGame();
            SetPauseMenuVisible(true);
        }
        
    }



    // Getter and setter for 'spellBookVisible'
    public static bool GetSpellBookVisible(){
        return spellBookVisible;
    }
    public static void SetSpellBookVisible(bool b){
        spellBookVisible = b;
    }

    // Getter and setter for 'pauseMenuVisible'
    public static bool GetPauseMenuVisible(){
        return pauseMenuVisible;
    }
    public static void SetPauseMenuVisible(bool b){
        pauseMenuVisible = b;
    }
}
