using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauzeMenuFuncions : MonoBehaviour
{
    public void Resume()
    {
        Input.GetKeyDown(KeyCode.Escape);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("The player has quit");
    }
}
