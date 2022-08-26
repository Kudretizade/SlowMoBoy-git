using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    private int CreditsScene = 1;

    private int MainMenuScene = 0;

    private int OptionsScene = 2;

    private int LevelSelectScene = 3;


    //level 1 = 4 id

    private int Level1 = 4;
    private int Level2 = 5;
    private int Level3 = 6;

//----------------------------------------------------

    public void MainMenuButton()
    {
        SceneManager.LoadScene(MainMenuScene);
    }
    public void LevelSelectButton()
    {
        SceneManager.LoadScene(LevelSelectScene);
    }
    public void OptionsButton()
    {
        SceneManager.LoadScene(OptionsScene);
    }
    public void CreditsButton()
    {
        SceneManager.LoadScene(CreditsScene);
    }
    public void QuitGameButton()
    {
        Application.Quit();
        Debug.Log("Application closed");
    }
//----------------------------------------------------

    public void Level1Button()
    {
        SceneManager.LoadScene(Level1);
    }
    public void Level2Button()
    {
        SceneManager.LoadScene(Level2);
    }
    public void Level3Button()
    {
        SceneManager.LoadScene(Level3);
    }
}
