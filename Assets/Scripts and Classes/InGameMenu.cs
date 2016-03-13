using UnityEngine;
using System.Collections;
[RequireComponent (typeof (InventoryGUI))]
public class InGameMenu : MonoBehaviour
{
    private Rect menuWindowRect = new Rect(Screen.width / 2 - 200, Screen.height / 2 - 300, 400, 600);
    private bool menuWindowToggle = false;
    private bool button1;

    InventoryGUI userInv;
    // Use this for initialization
    void Start()
    { //TODO: get component of each GUI type
        userInv = GetComponent<InventoryGUI>(); //ensures a GUI exists for each menu type
    }
    
    // Update is called once per frame
    void Update() //show window with hotkey Escape
    { //TODO: show other submenus with button presses
        if (Input.GetKey(KeyCode.Escape) && menuWindowToggle == false)
        {
            menuWindowToggle = true;
        }
    }
    void OnGUI()
    {
        if (menuWindowToggle == true)
        {
            menuWindowRect = GUI.Window(0, menuWindowRect, MenuWindowMethod, "Menu"); //create window
            if (button1)
            {
                userInv.SetToggle(true);

            }

        }
    }
    void MenuWindowMethod(int windowID)
    { //generate window buttons
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));

        GUILayout.BeginHorizontal();
        button1 = GUILayout.Button("Inventory", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Crafting", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Journal", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.Button("Survival Guide", GUILayout.Height(Screen.height / 5 - 200));
        GUILayout.EndHorizontal();

        GUILayout.EndArea();
    }
}