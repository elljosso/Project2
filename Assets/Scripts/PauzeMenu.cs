using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauzeMenu : MonoBehaviour
{
    public static bool GameIsPaused = true;
    public GameObject PauzeMenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        PauzeMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked; // Verberg de cursor
        Cursor.visible = false;
    }

    void Pause()
    {
        PauzeMenuUI.SetActive(true);
        Time.timeScale = 0.01f; // Verlaagde tijdsschaal (bijna gepauzeerd)
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None; // Toon de cursor
        Cursor.visible = true;
    }
}