using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanelScipt : MonoBehaviour
{
    //Storing variables that will be used in the code
    public GameObject Panel;

    //This function opens the panel when the  abutton is clicked
    public void OpenPanel()
    {
        if (Panel != null)
        {
            // this code opens and closes the panel when the button is click
            //checks if the panel is active when button is clicked again
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }
}
