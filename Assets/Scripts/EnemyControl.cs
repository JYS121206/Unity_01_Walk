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

    public void Progress(KeyCode correct, KeyCode incorrect1, KeyCode incorrect2)
    {

        if (Input.GetKeyDown(correct))
        {
            Destroy(gameObject);
            PLManager.Player.ForwardMovement();
            PLManager.Player.GetCombo();
            PLManager.Player.GetScore();
            uIWalk.limitTime += 0.1f;
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
            uIWalk.limitTime -= 6.0f;
        }
        uIWalk.SetCount(PLManager.Player.score, PLManager.Player.combo);
    }
}