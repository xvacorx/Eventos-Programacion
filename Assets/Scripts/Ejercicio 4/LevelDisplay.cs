using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class LevelDisplay : MonoBehaviour
{
    public TextMeshProUGUI levelText;
    private int contador;

    private void OnEnable()
    {
        LevelManager.levelChange += UpdateLevelDisplay;
    }
    private void OnDisable()
    {
        LevelManager.levelChange -= UpdateLevelDisplay;
    }
    void UpdateLevelDisplay()
    {
        contador++;
        levelText.text = "Nivel: " + contador;
    }
}