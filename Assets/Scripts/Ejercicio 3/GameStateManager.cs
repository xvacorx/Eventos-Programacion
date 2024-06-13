using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameStateManager : MonoBehaviour
{

    public delegate void OnGameStart();
    public static OnGameStart onGameStart;

    public delegate void OnGamePause();
    public static OnGamePause onGamePause;

    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        if (onGameStart != null)
        {
            onGameStart.Invoke();
        }
    }

    public void PauseGame()
    {
        if (onGamePause != null)
        {
            onGamePause.Invoke();
        }
        isPaused = true;
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        if (onGameStart != null)
        {
            onGameStart.Invoke();
        }
        isPaused = false;
        Time.timeScale = 1f;
    }


}
