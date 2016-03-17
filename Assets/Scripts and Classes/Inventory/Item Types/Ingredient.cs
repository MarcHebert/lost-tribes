using UnityEngine;
using System.Collections;
[System.Serializable]
public class Ingredient : Item
{
    public Ingredient(int id, Vector3 loc)
    {
        itemID = id;
        itemType = ItemType.Ingredient;
        referenceID = referenceIDCounter + 1;
        if(id == 1) //set appropriate icon, name, rid, description
        {
            itemIcon = null;
            itemName = "Stick";
            itemDesc = "A stick. Ideally used for crafting. Can be used for pleasure.";
            location = loc;
        }
        SpawnInWorld(this, loc);
        Debug.Log(this.itemName + " created");
    }
    public new Ingredient Clone()
    {
        Ingredient clone = new Ingredient(this.itemID, this.location);
        return clone;
    }
}
