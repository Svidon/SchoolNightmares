using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void ExitGame() {

        // For the unity editor testing
        //UnityEditor.EditorApplication.isPlaying = false;

        // For the standalone application
        Application.Quit();
    }
}
