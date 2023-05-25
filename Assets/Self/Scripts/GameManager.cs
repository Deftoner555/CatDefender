using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource musicAudioSource;

    private void Start()
    {
        //Play the music
        if (musicAudioSource != null)
        {
            musicAudioSource.Play();
        }
    }
    private void Update()
    {
        // Check for restart input
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }

    private void RestartGame()
    {
        //Load the Title screen scene
        SceneManager.LoadScene("TitleScreen");
    }

}
