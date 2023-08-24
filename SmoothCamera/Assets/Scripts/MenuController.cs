using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private const string SCENE_2D = "SampleScene";
    private const string SCENE_3D = "3dScene";

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        HandleEscape();
    }

    public void Load2dScene()
    {
        ChangeScene(SCENE_2D);
    }

    public void Load3dScene()
    {
        ChangeScene(SCENE_3D);
    }

    public void Show(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public void Hide(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }


    private void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void HandleEscape()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
