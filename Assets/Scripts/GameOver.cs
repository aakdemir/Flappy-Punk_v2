using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private AudioSource audioSource;
    private Transform transform;
    public float delay = 2f;
    private float minYPosition = -3.5f;
    private float maxYPosition = 8.5f;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        transform = GetComponent<Transform>();
    }

    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);

    }

    public void StartGameSequence()
    {
        
        GetComponent<PlayerControl>().enabled = true;
    }
    
    public void StartGameOverSequence()
    {
        audioSource.Stop();
        GetComponent<PlayerControl>().enabled = false;
        Invoke("ReloadLevel", delay);
    }

    public Boolean IsGameOver()
    {
        float yPosition = transform.position.y; 

        if (maxYPosition > yPosition && yPosition > minYPosition)
                return false;
        
        return true;
    }

}
