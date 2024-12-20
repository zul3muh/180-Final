using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Mateo Jimenez
 * handles player lives and death
 * 12/9/2024
 */

public class PlayerLives : MonoBehaviour
{
    public int lives = 3;

    public int coinScore = 0;

    public int deathY = -5;

    public GameObject respawnPoint;

    private bool attackState = false;


    //if player falls into void player will die
    void Update()
    {
        if (transform.position.y <= deathY)
        {
            respawn();
        }
     
    }
    //player picks up coins i collides with coin, or dies if collides with hazard
    private void OnCollisionEnter(Collision collision) { 
        if (collision.gameObject.GetComponent<Coins>())
        {
            Destroy(collision.gameObject);
            addCoinScore();
        }
        else if (collision.gameObject.GetComponent<Hazard>())
        {
            
            respawn();
        }
    }

    
     
    //subtracts a kife from player
    public void respawn()
    {
        lives--;

        if(lives == 0)
        {
            print("You Died");

            //change scene
        }
        else
        {
            transform.position = respawnPoint.transform.position;
        }
    }

    public void addCoinScore()
    {
        coinScore++;
    }
}
