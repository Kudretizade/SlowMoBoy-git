using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    private int CreditsScene = 1;

    private int MainMenuScene = 0;



    public void CreditsButton()
    {
        SceneManager.LoadScene(CreditsScene);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(MainMenuScene);
    }

    public void QuitGameButton()
    {
        Application.Quit();
        Debug.Log("Application closed");
    }


}
