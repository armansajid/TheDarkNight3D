using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject options;
    public GameObject credits;
    //public GameObject exist;
    

    public void loadOption()
    {
        
        options.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void loadCredits()
    {
        
        credits.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void backToMenu()
    {
       
        options.SetActive(false);
        credits.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }

   
}
