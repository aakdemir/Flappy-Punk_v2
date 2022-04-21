using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class ChildPot : MonoBehaviour
{
    PlayerControl player;
    GameOver gameOver;
    private void Start()
    {

        player = GameObject.Find("Player").GetComponent<PlayerControl>();
        gameOver = GameObject.Find("Player").GetComponent<GameOver>();

    }

    private void Update()
    {
        if (gameOver.IsGameOver())
        {
            RestartGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Player" )
        {
            if (gameObject.GetComponent<Collider>().enabled)
            {
                RestartGame();
            }
        }

        
    }

    public void RestartGame()
    {
        print("GAME OVER");
        gameOver.StartGameOverSequence();
        print("To play again,click the left mouse button.");
        gameOver.StartGameSequence();
    }

}
