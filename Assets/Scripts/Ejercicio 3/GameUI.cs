using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameUI : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject pausePanel;
    void OnEnable()
    {
        GameStateManager.onGameStart += OnGameStart;
        GameStateManager.onGamePause += OnGamePause;
    }
    void OnDisable()
    {
        GameStateManager.onGameStart -= OnGameStart;
        GameStateManager.onGamePause -= OnGamePause;
    }
    void OnGameStart()
    {
        startPanel.SetActive(false);
        pausePanel.SetActive(false);
    }
    void OnGamePause()
    {
        startPanel.SetActive(false);
        pausePanel.SetActive(true);
    }
}
