using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    public EnemyControl enemyControl;

    public KeyCode correctKey = KeyCode.DownArrow;
    public KeyCode incorrectKey1 = KeyCode.RightArrow;
    public KeyCode incorrectKey2 = KeyCode.UpArrow;

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