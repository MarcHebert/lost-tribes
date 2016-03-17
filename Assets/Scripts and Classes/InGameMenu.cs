using UnityEngine;
using System.Collections;
public class InGameMenu : MonoBehaviour
{
    private Rect menuWindowRect = new Rect(Screen.width / 2 - 200, Screen.height / 2 - 300, 400, 600);
    private bool menuWindowToggle = false;
    private bool button1;
    
    // Use this for initialization
    void Start(){ 

    }
    
    // Update is called once per frame
    void Update() //show window with hotkey Escape
    { //TODO: show other submenus with button presses
        if (Input.GetKey(KeyCode.M) && menuWindowToggle == false)
        {
            menuWindowToggle = true;
        }
    }
    void OnGUI()
    {
        if (menuWindowToggle)
        {
            menuWindowRect = GUI.Window(0, menuWindowRect, MenuWindowMethod, "Menu"); //create window
            
            if (Input.GetKey(KeyCode.Escape) && menuWindowToggle == true)
            {
                menuWindowRect = new Rect(Screen.width / 2 - 200, Screen.height / 2 - 300, 400, 600);
                menuWindowToggle = false;
            }
            
        }
    }
    void MenuWindowMethod(int windowID)
    { //generate window buttons
        GUILayout.BeginArea(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 290, 400, 580));

        GUILayout.BeginHorizontal();
        GUILayout.Button("Inventory", GUILayout.Height(Screen.height / 4 - 200));
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        GUILayout.Button("Crafting", GUILayout.Height(Screen.height / 4 - 200));
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        GUILayout.Button("Journal", GUILayout.Height(Screen.height / 4 - 200));
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        GUILayout.Button("Survival Guide", GUILayout.Height(Screen.height / 4 - 200));
        GUILayout.EndHorizontal();

        GUILayout.EndArea();
    }
}