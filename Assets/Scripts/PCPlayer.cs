using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCPlayer : MonoBehaviour
{
    //public float hp = 100.0f;

    [HideInInspector]
    public int score = 0;
    [HideInInspector]
    public int combo = 0;

    private void Start()
    {
        PLManager.Player = this;
    }

    public void ForwardMovement()
    {
        transform.position += new Vector3(5, 0, 0);
    }

    public void BackwardMovement()
    {
        transform.position -= new Vector3(5, 0, 0);
    }


    public void GetCombo()
    {
        combo++;
    }

    public void LostCombo()
    {
        combo = 0;
    }

    public void GetScore()
    {
        if (combo >= 10)
        {
            score += 10;
            combo = 0;
        }
    }

    public void GetMoney()
    {
        if (score <= 9)
        {
            Wallet.money += 0;
        }

        else if(score <= 10)
        {
            Wallet.money += 100;
        }

        else if (score <= 30)
        {
            Wallet.money += 300;
        }

        else if (score <= 50)
        {
            Wallet.money += 600;
        }


        else if (score <= 80)
        {
            Wallet.money += 1000;
        }


        else if (score <= 100)
        {
            Wallet.money += 1200;
        }

        else if (score <= 120)
        {
            Wallet.money += 1500;
        }

        else if (score <= 150)
        {
            Wallet.money += 2000;
        }

        else if (score <= 170)
        {
            Wallet.money += 2500;
        }
        else
        {
            Wallet.money += 3000;
        }
    }
}