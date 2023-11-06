using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadToLevels : MonoBehaviour
{
    public void LoadLevels(string loadToScene)
    {
        SceneManager.LoadScene(loadToScene);
    }
}
