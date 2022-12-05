using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
    public void OpenMain()
    {
        SceneManager.LoadScene("Main");
    }

    public void OpenGame()
    {
        SceneManager.LoadScene("Walk");
    }

    public void OpenEnd()
    {
        SceneManager.LoadScene("EndWalk");
    }
}
