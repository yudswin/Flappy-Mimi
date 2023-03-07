using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public void playGame() {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void exitGame() {
        Application.Quit();
    }
}
