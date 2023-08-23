using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    private const string MAIN_MENU = "MainScene";

    private void Update()
    {
        HandleEscape();
    }

    private void HandleEscape()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(MAIN_MENU);
        }
    }

}
