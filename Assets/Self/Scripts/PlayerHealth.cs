using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 5;
    private int currentHealth;
    public GameObject textLose;
    public GameObject textWin;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakePDamage(int pDamage)
    {
        currentHealth -= pDamage;

        if (currentHealth <= 0)
        {
            diePlayer();
        }
    }

    private void diePlayer()
    {
        //Handle player death here, such as showing a game over screen,
        //restarting the level, etc.
        //For now, disable the player object
        gameObject.SetActive(false);
        textLose.SetActive(true);
    }

}
