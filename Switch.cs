using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch_btn : MonoBehaviour
{
public Image On;
public Image Off;
public Image img;
int index;

    
 void Update()
    {
        if (index == 1)
        {
            img.gameObject.SetActive(false);

        }
        if (index == 0)
        {
            img.gameObject.SetActive(true);

        }
        
    }

public void ON() {
        index = 1;
        On.gameObject.SetActive(false);
        Off.gameObject.SetActive(true);

    }

    public void OFF()
    {
        index = 0;
        On.gameObject.SetActive(true);
        Off.gameObject.SetActive(false);
    }

 
   
}
