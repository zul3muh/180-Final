using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Cetz, Zulema 
/// 12/3/24
/// Handles the main menu UI and game over screen
/// </summary>
public class MainMenuUI : MonoBehaviour
{

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        print ("sceneswitched");
    }
}
