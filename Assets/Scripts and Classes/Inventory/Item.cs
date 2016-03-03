using System;
using System.Collections;
using UnityEngine;
//Author: Zain
[System.Serializable]
public abstract class Item
{
    private string itemName;
    private int itemID;
    private int referenceID;
    private string itemDesc;
    private Texture2D itemIcon;
    private ItemType itemType;
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

    }
    public void SpawnInWorld(float x, float y, float z)
    {

    }
    public void SpawnInChest(int chestID)
    {

    }
    public void SpawnInInventory(int inventoryID)
    {

    }
    public void Despawn()
    {

    }
}
