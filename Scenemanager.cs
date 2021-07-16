using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Scene管理Script
/// </summary>
public class Scenemanager : MonoBehaviour
{
    
    /// <summary>
    /// SingleでSceneを読み込み
    /// </summary>
    /// <param name="scenename">LoadするSceneの名前</param>
    public void NextSceneSingle(string scenename)
    {
        SceneManager.LoadScene(scenename,LoadSceneMode.Single);
    }

    /// <summary>
    /// AddtiveでSceneを読み込み
    /// </summary>
    /// <param name="scenename">LoadするSceneの名前</param>
    public void NextSceneAddtive(string scenename)
    {
        SceneManager.LoadScene(scenename, LoadSceneMode.Additive);
    }
}
