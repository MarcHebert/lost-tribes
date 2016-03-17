using UnityEngine;
using System.Collections;
[System.Serializable]
public abstract class Weapon : Item
{ //TODO: finish class with all functionality
   
    public int power;
    public int knockback;
    public WeaponType weaponType;
    public bool isPoison = false;
    public Weapon(int id, string name, int rid, Texture2D icon, string description, ItemType type)
    {
        itemID = id;
        itemName = name;
        referenceID = rid;
        itemIcon = icon;
        itemDesc = description;
        itemType = type;
    }
    public enum WeaponType
    {
        Spear,
        Bow
    }
    public void SetDamage(int newDamage)
    {
        power = newDamage;
    }
    public void SetKnockback(int newKnockback)
    {
        knockback = newKnockback;
    }
    public void SetPoison(bool poison)
    {
        isPoison = poison;
    }
    public void DamageOnContact()
    {
        
    }
}
