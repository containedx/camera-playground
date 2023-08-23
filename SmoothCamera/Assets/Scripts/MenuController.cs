using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private const string SCENE_2D = "SampleScene";
    private const string SCENE_3D = "3dScene";

    public void Load2dScene()
    {
        ChangeScene(SCENE_2D);
    }

    public void Load3dScene()
    {
        ChangeScene(SCENE_3D);
    }


    private void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    
}
