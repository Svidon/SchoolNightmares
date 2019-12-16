using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButtonController : MonoBehaviour
{
        public void StartScreen(){

                // Restart the level
                SceneManager.LoadScene("Startscreen", LoadSceneMode.Single);
	}
}