using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public EnemyControl enemyControl;

    public KeyCode correctKey = KeyCode.RightArrow;
    public KeyCode incorrectKey1 = KeyCode.UpArrow;
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