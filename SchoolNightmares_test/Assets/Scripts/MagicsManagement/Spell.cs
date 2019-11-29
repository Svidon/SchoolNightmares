using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Spell {

    // Spell attributes
    public string name;
    public string description;
    public Sprite icon;
    public int id;
    public bool learned;

    public Spell(Spell s){
        name = s.name;
        description = s.description;
        icon = s.icon;
        id = s.id;
        learned = false;
    }


}
