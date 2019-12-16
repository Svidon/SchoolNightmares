using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    public GameObject pauseMenu;

    public void ShowHideMenu(){
        if(UIManager.GetPauseMenuVisible()){ // menu is visible, hide it
            // Set menu inactive and set UIManager control variable to false
            pauseMenu.SetActive(false);
            WorldControl.UnFreezeGame();
            UIManager.SetPauseMenuVisible(false);
        } else { // menu is not visible, show it
            pauseMenu.SetActive(true);
            WorldControl.FreezeGame();
            UIManager.SetPauseMenuVisible(true);
        }
    }
}
