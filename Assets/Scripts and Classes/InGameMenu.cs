using UnityEngine;
using System.Collections;

public class InGameMenu : MonoBehaviour
{
    private Rect menuWindowRect = new Rect(Screen.width / 2 - 200, Screen.height / 2 - 300, 400, 600);
    private bool menuWindowToggle = false;
    private bool button1;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && menuWindowToggle == false)
        {
            menuWindowToggle = true;
            OnGUI(); 
        }
    }
    void OnGUI()
    {
        if (menuWindowToggle == true)
        {
            menuWindowRect = GUI.Window(0, menuWindowRect, MenuWindowMethod, "Menu");
            if (Input.GetKey(KeyCode.Space) && menuWindowToggle == true)
            {
                menuWindowToggle = false;
                menuWindowRect = new Rect(0, 0, Screen.width, Screen.height);
            }
        }
    }
    void MenuWindowMethod(int windowID)
    {

    }
}