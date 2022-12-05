using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMain : MonoBehaviour
{
    public Text moneyCount;

    void Start()
    {
        moneyCount = GetComponentInChildren<Text>();
    }

    void Update()
    {
        SetMainCount();
    }

    public void SetMainCount()
    {
        moneyCount.text = PLManager.Player.money + " ";
    }
}