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

    public GameObject playText;
    public GameObject quitText;
   
    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    // Quits the game when the ui button for is clicked
    public void Quit()
    {
        print("Quit Game");
        Application.Quit();
    }
}
