using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryGUI : MonoBehaviour {
    private Rect inventoryWindowRect = new Rect(0, 0, Screen.width, Screen.height);
    private bool inventoryWindowToggle = false;
    private Dictionary<int, Texture2D> inventoryNameDicitonary;
    public Item stickItem;
    private static int INVENTORYSIZE = 45;
    private static int STACKLIMIT;
    private InvType invType;
    public enum InvType
    {
        Inventory,
        Chest
    }
    public InventoryGUI(int type)
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
    private Dictionary<int, Texture2D> inventoryNameDictionary = new Dictionary<int, Texture2D>()
    {
        {0, null},
        {1, null},
        {2, null},
        {3, null},
        {4, null},
        {5, null},
        {6, null},
        {7, null},
        {8, null},
        {9, null},
        {10, null},
        {11, null},
        {12, null},
        {13, null},
        {14, null},
        {15, null},
        {16, null},
        {17, null},
        {18, null},
        {19, null},
        {20, null},
        {21, null},
        {22, null},
        {23, null},
        {24, null},
        {25, null},
        {26, null},
        {27, null},
        {28, null},
        {29, null},
        {30, null},
        {31, null},
        {32, null},
        {33, null},
        {34, null},
        {35, null},
        {36, null},
        {37, null},
        {38, null},
        {39, null},
        {40, null},
        {41, null},
        {42, null},
        {43, null},
        {44, null},
    };
    // Use this for initialization

    void AddItem(int rid)
    {

    }

    void Start()
    {
        stickItem = new Stick(new Vector3(2245.7F, 10.95F, 3160.7F));
        Debug.Log("Stick instantiated");
    }

    // Update is called once per frame
    void Update()
    { //opens in game menu with hotkey I
        if (Input.GetKey(KeyCode.I))
        {
            inventoryWindowToggle = true;
        }
    }
    void OnGUI()
    {
        if (inventoryWindowToggle)
        {
            inventoryWindowRect = GUI.Window(0, inventoryWindowRect, InventoryWindowMethod, "Inventory"); //create window
            if (Input.GetKey(KeyCode.Escape)) //exit window
            {
                inventoryWindowToggle = false;
                inventoryWindowRect = new Rect(0, 0, Screen.width, Screen.height);
            }
            
        }
    }
    void InventoryWindowMethod(int windowID){
        GUILayout.BeginArea(new Rect(0, 20, Screen.width, Screen.height - 20)); //generate window buttons

        GUILayout.BeginHorizontal();
        GUILayout.Button(inventoryNameDictionary[0], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[1], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[2], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[3], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[4], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[5], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[6], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[7], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[8], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Button(inventoryNameDictionary[9], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[10], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[11], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[12], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[13], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[14], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[15], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[16], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[17], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Button(inventoryNameDictionary[18], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[19], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[20], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[21], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[22], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[23], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[24], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[25], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[26], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Button(inventoryNameDictionary[27], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[28], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[29], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[30], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[31], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[32], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[33], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[34], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[35], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Button(inventoryNameDictionary[36], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[37], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[38], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[39], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[40], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[41], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[42], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[43], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.Button(inventoryNameDictionary[44], GUILayout.Height((Screen.height - 40) / 6));
        GUILayout.EndHorizontal();

        GUILayout.EndArea();
    }
}
