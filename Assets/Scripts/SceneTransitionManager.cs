using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//シーン遷移に関するすk理ぷと
public class SceneTransitionManager : MonoBehaviour
{

    public void LoadNewScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }




 
}
