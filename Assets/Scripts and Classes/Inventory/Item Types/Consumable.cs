using UnityEngine;
using System.Collections;
[System.Serializable]
public abstract class Consumable : Item {
    private int healthAffect;
    public void Consume()
    {
        //TODO: create consume function that affects wellness depending on healthAffect
    }
}
