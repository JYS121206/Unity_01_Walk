using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIEnd : MonoBehaviour
{
    public Text scoreCount;
    public Text moneyCount;

    void Start()
    {
        scoreCount = GetComponentsInChildren<Text>()[1];
        moneyCount = GetComponentsInChildren<Text>()[2];
    }

    private void Update()
    {
        SetEndCount();
    }

    public void SetEndCount()
    {
        scoreCount.text = PLManager.Player.score + " Á¡";
        moneyCount.text = "+ " + PLManager.Player.money;
    }
}