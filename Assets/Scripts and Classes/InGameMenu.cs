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
    {
        userInv = GetComponent<InventoryGUI>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && menuWindowToggle == false)
        {
            menuWindowToggle = true;
        }
    }
    void OnGUI()
    {
        if (menuWindowToggle == true)
        {
            menuWindowRect = GUI.Window(0, menuWindowRect, MenuWindowMethod, "Menu");
            if (button1)
            {
                userInv.SetToggle(true);

            }

        }
    }
    void MenuWindowMethod(int windowID)
    {
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