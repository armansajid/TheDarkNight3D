using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class LoadingScene : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject loadingScreen;
    public Slider loadingBar;

    
    
   
   public void LoadScene(int levelIndex)
    {
       /* loadingScreen.SetActive(true);
        mainMenu.SetActive(false);*/
        StartCoroutine(Loadscene(levelIndex));
    }

    IEnumerator Loadscene(int levelIndex)
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);

        loadingScreen.SetActive(true);
       //Time.timeScale = 1f;
        while (!operation.isDone)
        {
           
            loadingBar.value = operation.progress;
            yield return null;
        }

        //SceneManager.LoadScene(1);
    }

   

}
