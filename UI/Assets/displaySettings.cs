using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displaySettings : MonoBehaviour
{
    public GameObject Settings;
    public GameObject MainMenu;
    public void DisplaySettings()
    {
        MainMenu.SetActive(false);
        Settings.SetActive(true);
    }
    public void DisplayMenu()
    {
        MainMenu.SetActive(true);
        Settings.SetActive(false);
    }
}
