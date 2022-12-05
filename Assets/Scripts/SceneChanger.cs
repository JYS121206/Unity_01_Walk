using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
    public void OpenMain()
    {
        Wallet.wallet += Wallet.money;
        SceneManager.LoadScene("Main");
    }

    public void OpenGame()
    {
        Wallet.money = 0;
        SceneManager.LoadScene("Walk");
    }

    public void OpenEnd()
    {
        SceneManager.LoadScene("EndWalk");
    }
}
