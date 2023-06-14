using System.Collections;
using System.Collections.Generic;
//namespace necessary for conditional compiling
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//make the script execute at last because the UI stuff can load later
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    //starting scene one (main) from play button
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    //ending the game
    //conditional compiling --> ending the game in the unity editor when playing in the editor
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    //returning to the menu from the game
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }


}
