using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    //----------------------------

    [SerializeField] GameObject GameOverScreen;
    [SerializeField] GameObject GameWonScreen;

    //----------------------------

    [SerializeField] private AudioSource GameWinSound;
    [SerializeField] private AudioSource GameOverSound;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Block")
        {
            movement.enabled = false;
            Time.timeScale = 0;
            GameOverScreen.SetActive(true);
            GameOverSound.Play();
        }

        if (collisionInfo.collider.tag == "GameWon")
        {
            movement.enabled = false;
            Time.timeScale = 0;
            GameWonScreen.SetActive(true);
            GameWinSound.Play();
        }
    }

}
