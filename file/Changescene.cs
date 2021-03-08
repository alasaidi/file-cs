using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class Changescene : MonoBehaviour
{
    Canvas canvas;

   

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void changeScene(int changetoscene)

    { 
            SceneManager.LoadScene(changetoscene) ;
        

    }
    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Forest");
    }
  
}