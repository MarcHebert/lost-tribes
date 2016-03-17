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
    private static Texture2D blank = Resources.Load("blankicon") as Texture2D;
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
        {0, blank},
        {1, blank},
        {2, blank},
        {3, blank},
        {4, blank},
        {5, blank},
        {6, blank},
        {7, blank},
        {8, blank},
        {9, blank},
        {10, blank},
        {11, blank},
        {12, blank},
        {13, blank},
        {14, blank},
        {15, blank},
        {16, blank},
        {17, blank},
        {18, blank},
        {19, blank},
        {20, blank},
        {21, blank},
        {22, blank},
        {23, blank},
        {24, blank},
        {25, blank},
        {26, blank},
        {27, blank},
        {28, blank},
        {29, blank},
        {30, blank},
        {31, blank},
        {32, blank},
        {33, blank},
        {34, blank},
        {35, blank},
        {36, blank},
        {37, blank},
        {38, blank},
        {39, blank},
        {40, blank},
        {41, blank},
        {42, blank},
        {43, blank},
        {44, blank},
    };
    

    void AddItem(int rid)
    {

    }

    void Start() // Use this for initialization
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

        for (int i = 0; i < 45; i++)
        {
            inventoryNameDictionary[i] = blank;
        }

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
