using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private EnemySpawner enemySpawner;
    private PlayerHealth playerHealth;

    private bool isGameOver = false;
    private bool isGameWon = false;

    private void Start()
    {
        enemySpawner = FindObjectOfType<EnemySpawner>();
        playerHealth = FindObjectOfType<PlayerHealth>();

        if (playerHealth != null)
            playerHealth.OnPlayerDeath += GameOver;

        if (enemySpawner != null)
            enemySpawner.OnEnemyDefeated += CheckWinCondition;
    }

    private void Update()
    {
        if (isGameOver || isGameWon)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                RestartLevel();
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                QuitGame();
            }
        }
    }

    private void GameOver()
    {
        isGameOver = true;
        Debug.Log("Game Over :(");
        //handle game logic here
    }

    private void CheckWinCondition()
    {
        if (enemySpawner != null && enemySpawner.GetCurrentEnemyCount() <= 0)
        {
            isGameWon = true;
            Debug.Log("Home defended! :D");
        }
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
