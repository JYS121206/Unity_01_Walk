using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIWalk : MonoBehaviour
{
    public Text scoreCount;
    public Text comboCount;
    public Image timeCount;

    public float limitTime = 50.0f;
    bool isPause;

    SceneChanger sceneChanger;

    void Awake()
    {
        scoreCount= GetComponentsInChildren<Text>()[0];
        comboCount = GetComponentsInChildren<Text>()[1];
        timeCount = GetComponentsInChildren<Image>()[6];
        isPause = false;

        sceneChanger = GameObject.FindGameObjectWithTag("Canvas").GetComponent<SceneChanger>();
    }

    private void Update()
    {
        limitTime -= Time.deltaTime;
        SetTimegage();
        PlayManager();
    }

    public void SetCount(int score, int combo)
    {
        scoreCount.text = score +" ";
        comboCount.text = combo + " ";
    }

    public void SetTimegage()
    {
        timeCount.fillAmount = limitTime / 50.0f;

        if (limitTime >= 50)
        {
            limitTime = 50;
        }

        if (limitTime <= 0)
        {
            Debug.Log("게임 종료");
            PLManager.Player.GetMoney();
            sceneChanger.OpenEnd();
        }
    }

    public void PlayManager()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (isPause == false)
            {
                OnClickPlay();
                return;
            }

            if (isPause == true)
            {
                OnClickStop();
                return;
            }
        }
    }

    public void OnClickPlay()
    {
        Time.timeScale = 0;
        isPause = true;   
    }

    public void OnClickStop()
    {
        Time.timeScale = 1;
        isPause = false;
        
    }
}