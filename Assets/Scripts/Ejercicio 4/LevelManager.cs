using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{

    public delegate void LevelChange();
    public static event LevelChange levelChange;

    private bool isLevelChanged = false;

    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.K))
        {
            ChangeLevel();
        }
    }
    void ChangeLevel()
    {
        levelChange?.Invoke();

        isLevelChanged = true;
    }
    public bool IsLevelChanged()
    {
        return isLevelChanged;
    }

    private void OnDisable()
    {
        isLevelChanged = false;
    }
}
