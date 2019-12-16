using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldControl : MonoBehaviour
{
    void Start(){
        Time.timeScale = 1f;
    }


    // FUnctions to freeze and unfreeze the world
    public static void FreezeGame(){
        Time.timeScale = 0f;
    }

    public static void UnFreezeGame(){
        Time.timeScale = 1f;
    }

    // For buttons usage
    public void ButtonUnFreezeGame(){
        Time.timeScale = 1f;
    }
}
