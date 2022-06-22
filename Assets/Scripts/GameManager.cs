using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public PlayerController player;

    private void Awake()
    {

        Application.targetFrameRate = 60;
        Pause();
    }

    public void GameOver() 
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Debug.Log("Game Over");

        Pause();
    }

    public void IncreaseScore() 
    {
        score++;
        scoreText.text = score.ToString();
    }
    public void Pause() 
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void Play() 
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;

        PipesMove[] pipes = FindObjectsOfType<PipesMove>();
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }
}
