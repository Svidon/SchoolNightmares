using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookButtonController : MonoBehaviour
{

    public GameObject spellbook;
    public Button myButton;

	void Start () {
		Button btn = myButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){

        // Hide/Show SpellBook
        if (UIManager.GetSpellBookVisible() == true){
            spellbook.SetActive(false);
		    UIManager.SetSpellBookVisible(false);
        } else if (UIManager.GetSpellBookVisible() == false){
            spellbook.SetActive(true);
            UIManager.SetSpellBookVisible(true);
        }
	}
}
