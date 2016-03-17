using System;
using System.Collections;
using UnityEngine;
//Author: Zain
[System.Serializable]
public abstract class Item
{
    GameObject itemInstance;
    public string itemName;
    public int itemID;
    public int referenceID;
    public string itemDesc;
    public Texture2D itemIcon;
    public ItemType itemType;
    public int referenceIDCounter = 0;
    public Vector3 location;
    public enum ItemType
    {
        Weapon,
        Consumable,
        Ingredient,
        QuestItem
    }
    public void SetItemType(ItemType type)
    {
        itemType = type;
    }
    public ItemType GetItemType()
    {
        return itemType;
    }
    public void SetName(string name)
    {
        itemName = name;
    }
    public string GetName()
    {
        return itemName;
    }
    public void SetItemID(int newID)
    {
        itemID = newID;
    }
    public int GetItemID()
    {
        return itemID;
    }
    public void SetReferenceID(int newID)
    {
        referenceID = newID;
    }
    public int GetReferenceID()
    {
        return referenceID;
    }
    public void SetDesc(string desc)
    {
        itemDesc = desc;
    }
    public string GetDesc()
    {
        return itemDesc;
    }
    public void SetIcon(Texture2D icon)
    {
        itemIcon = icon;
    }
    public Texture2D GetIcon()
    {
        return itemIcon;
    }
    public void Clone()
    {
        //TODO: write clone function following prototype pattern
        //copy item info from rid to new rid
        //use spawn in __ function
    }
    public void SpawnInWorld(Item toSpawn, Vector3 loc)
    {
        //TODO: write function
        itemInstance =
            GameObject.Instantiate(Resources.Load(toSpawn.itemName),
            loc,
            Quaternion.identity) as GameObject;
        Debug.Log(toSpawn.itemName + " spawned");
    }
    public void SpawnInChest(int chestID)
    {
        //TODO: write function
    }
    public void SpawnInInventory(int inventoryID)
    {
        //TODO: write function
    }
    public void Despawn()
    {
        GameObject.Destroy(itemInstance);
    }
}
