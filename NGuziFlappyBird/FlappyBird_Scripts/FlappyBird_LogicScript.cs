using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class FlappyBird_LogicScript : MonoBehaviour
{
    //Variables & References
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;
    public AudioSource splatSFX;
    public bool audioPlayed = false;

    private void Start()
    {
        splatSFX = GetComponent<AudioSource>();
    }

    [ContextMenu("Increase Score")] //in order to run function directly from unity and test if it works
    public void addScore(int scoreToAdd) // function to add score to UI as player passes through pipes 
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void gameOver() //function that triggers game over screen when bird crashes or goes off screen
    {
        gameOverScreen.SetActive(true);
        if (audioPlayed == false) // plays squawk sound upon impact of pipe or bird goes off screen
        {
            splatSFX.Play();
            audioPlayed = true;
        }
    }
}
