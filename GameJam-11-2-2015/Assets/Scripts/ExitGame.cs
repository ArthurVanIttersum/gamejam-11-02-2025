using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    //simple script to close the game.
    //can be activated using events.
    public void QuitGame()
    {
        Application.Quit();
    }
}
