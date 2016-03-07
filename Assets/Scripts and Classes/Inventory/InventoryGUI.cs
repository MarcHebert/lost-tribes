using UnityEngine;
using System.Collections;

public class InventoryGUI : MonoBehaviour {
    private Rect inventoryWindowRect = new Rect(0, 0, Screen.width, Screen.height);
    private bool inventoryWindowToggle = false;
    private bool button1;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.I))
        {
            inventoryWindowToggle = true;
            OnGUI();
        }
    }
    void OnGUI()
    {
        if (inventoryWindowToggle)
        {
            inventoryWindowRect = GUI.Window(0, inventoryWindowRect, InventoryWindowMethod, "Inventory");
            if (Input.GetKey(KeyCode.Escape))
            {
                inventoryWindowToggle = false;
                inventoryWindowRect = new Rect(0, 0, Screen.width, Screen.height);
            }
            
        }
    }
    void InventoryWindowMethod(int windowID){
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));

        GUILayout.BeginHorizontal();
        GUILayout.Button("Item 1", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 2", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 3", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 4", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 5", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 6", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 7", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 8", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 9", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Button("Item 10", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 11", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 12", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 13", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 14", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 15", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 16", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 17", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 18", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Button("Item 19", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 20", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 21", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 22", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 23", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 24", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 25", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 26", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 27", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Button("Item 28", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 29", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 30", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 31", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 32", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 33", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 34", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 35", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 36", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Button("Item 37", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 38", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 39", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 40", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 41", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 42", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 43", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 44", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Item 45", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.EndHorizontal();

        GUILayout.EndArea();
    }
}
