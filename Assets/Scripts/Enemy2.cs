using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public EnemyControl enemyControl;

    public KeyCode correctKey = KeyCode.UpArrow;
    public KeyCode incorrectKey1 = KeyCode.RightArrow;
    public KeyCode incorrectKey2 = KeyCode.DownArrow;

    private void Start()
    {
        enemyControl = GetComponent<EnemyControl>();
    }

    public void ProgressEnemy()
    {
        enemyControl.Progress(correctKey, incorrectKey1, incorrectKey2);
    }

    public void BackwardMovement()
    {
        transform.position -= new Vector3(5, 0, 0);
    }
}