using UnityEngine;
using System.Collections;
//Author: Zain
//
public class Inventory : MonoBehaviour {
    private static int INVENTORYSIZE = 45;
    private static int STACKLIMIT;
    private ArrayList inventory = new ArrayList(INVENTORYSIZE);
    private int[] stack = new int[INVENTORYSIZE];
    private InvType invType;
    public enum InvType
    {
        Inventory,
        Chest
    }
    public Inventory(int type)
    {
        if (type == 0) //TODO: integrate inventory with inventory GUI and items
        {
            invType = InvType.Inventory;
            STACKLIMIT = 15;
        }
        else if (type == 1)
        {
            invType = InvType.Chest;
            STACKLIMIT = 1500;
        }
    }
    // Use this for initialization
    void Start()
    {
        
    }

    //Update is called once per frame
    void Update()
    {
        
    }
}
