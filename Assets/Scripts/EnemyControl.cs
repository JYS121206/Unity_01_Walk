using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public PStageManager stageManager;
    public UIWalk uIWalk;
    void Start()
    {
        uIWalk = GameObject.FindGameObjectWithTag("Canvas").GetComponent<UIWalk>();
    }

    public void SetManager(PStageManager manager)
    {
        stageManager = manager;
    }

    public void CurrentEnemy(KeyCode correct, KeyCode incorrect1, KeyCode incorrect2)
    {
        for (int i = 0; i > stageManager.currentEnemyCount; i++)
        {
            if (stageManager.currentEnemy == i)
            {
                Progress(correct, incorrect1, incorrect2);
                break;
            }
        }
    }

    public void Progress(KeyCode correct, KeyCode incorrect1, KeyCode incorrect2)
    {

        if (Input.GetKeyDown(correct))
        {
            Destroy(gameObject);
            PLManager.Player.ForwardMovement();
            PLManager.Player.GetCombo();
            PLManager.Player.GetScore();
            uIWalk.limitTime += 2f;
            stageManager.currentEnemy++;
            //0.5�� �ڿ� �ٽ� �������� ��ܿ��� ����
            //(0.5�� ������) //����
            PLManager.Player.BackwardMovement(); //�÷��̾��� ��ġ -5(x��)
            stageManager.BackwardMovement(); //Enemy�� ��ġ -5(x��)
            stageManager.PushNewEnemy();
        }

        else if (Input.GetKeyDown(incorrect1) || Input.GetKeyDown(incorrect2))
        {
            PLManager.Player.LostCombo();
            uIWalk.limitTime -= 6;
        }
        uIWalk.SetCount(PLManager.Player.score, PLManager.Player.combo);
    }
}