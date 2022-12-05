using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCPlayer : MonoBehaviour
{
    //public float hp = 100.0f;

    [HideInInspector]
    public int money = 0;
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
        if (score >= 10)
        {
            money += 100;
        }

        else if (score >= 30)
        {
            money += 300;
        }

        else if (score >= 50)
        {
            money += 600;
        }


        else if (score >= 80)
        {
            money += 1000;
        }


        else if (score >= 100)
        {
            money += 1200;
        }

        else if (score >= 120)
        {
            money += 1500;
        }

        else if (score >= 150)
        {
            money += 2000;
        }

        else if (score >= 170)
        {
            money += 2500;
        }
        else
        {
            money += 3000;
        }
    }
}