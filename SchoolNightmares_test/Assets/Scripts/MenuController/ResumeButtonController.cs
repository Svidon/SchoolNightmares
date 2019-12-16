using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButtonController : MonoBehaviour
{
    public GameObject pauseMenu;

    public void HideMenu(){
        // Set menu inactive and set UIManager control variable to false
        pauseMenu.SetActive(false);
        WorldControl.UnFreezeGame();
        UIManager.SetPauseMenuVisible(false);
    }
}
