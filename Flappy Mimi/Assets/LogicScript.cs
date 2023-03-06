using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerscore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;

    
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) {
        playerscore += scoreToAdd;
        scoreText.text = playerscore.ToString();
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
        
    }
}
