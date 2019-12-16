using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonController : MonoBehaviour
{
	public void RestartLevel(){

        // Restart the level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
