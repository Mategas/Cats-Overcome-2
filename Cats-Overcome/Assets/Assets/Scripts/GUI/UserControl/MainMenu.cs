using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{

    bool NewGame = true;

    public void StartGame()
    {
        if (NewGame)
        {
            NewGame = true;
            Application.LoadLevel(1);
        }
        else
        {
            // Here we load the game
        }

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
