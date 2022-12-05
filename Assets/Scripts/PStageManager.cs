using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PStageManager : MonoBehaviour
{
    public string[] EnemiesName = { "Enemy1", "Enemy2", "Enemy3" };

    public GameObject[] Enemies;

    public int currentEnemy = 0;

    public int currentEnemyCount = 5;

    void Awake()
    {
        //Object enemy1 = Resources.Load("Enemy1");
        //Instantiate(enemy1, new Vector3(-5.25f, -1.46f, 0), Quaternion.identity);

        //Object enemy2 = Resources.Load("Enemy2");
        //Instantiate(enemy2, new Vector3(0.25f, -1.46f, 0), Quaternion.identity);

        //Object enemy3 = Resources.Load("Enemy3");
        //Instantiate(enemy3, new Vector3(5.25f, -1.46f, 0), Quaternion.identity);

        GenerateStage(200);
    }

    private void Update()
    {
        Etc();
    }


    public void GenerateStage(int enemyCount)
    {
        Enemies = new GameObject[enemyCount];

        for (int i = 0; i < currentEnemyCount; i++)
        {
            GameObject enmey = SpawnRandomEnemy();
            Enemies[i] = enmey;

            enmey.transform.position = new Vector3(-5.25f + (5 * i), -1.46f, 0);
        }
    }

    public void PushNewEnemy()
    {
        GameObject enmey = SpawnRandomEnemy();
        Enemies[currentEnemyCount] = enmey;

        enmey.transform.position = new Vector3(-5.25f + (5 * 4), -1.46f, 0);
        currentEnemyCount++;
    }


    public GameObject SpawnRandomEnemy()
    {
        int rand = Random.Range(0, 3);
        if (EnemiesName.Length <= rand)
            return null;

        string enemyName = EnemiesName[rand];

        Object enemy1 = Resources.Load(enemyName);

        GameObject enemyObject = (GameObject)Instantiate(enemy1, Vector3.zero, Quaternion.identity);

        if (enemyObject.GetComponent<EnemyControl>())
            enemyObject.GetComponent<EnemyControl>().SetManager(this);

        return enemyObject;
    }

    public void Etc()
    {
        //if (Enemies[currentEnemy].GetComponent<Enemy1>())
        //    Enemies[currentEnemy].GetComponent<Enemy1>().ProgressEnemy();

        //if (Enemies[currentEnemy].GetComponent<Enemy2>())
        //    Enemies[currentEnemy].GetComponent<Enemy2>().ProgressEnemy();

        //if (Enemies[currentEnemy].GetComponent<Enemy3>())
        //    Enemies[currentEnemy].GetComponent<Enemy3>().ProgressEnemy();

        //*
        //위 코드는 Enemy1부터 Enemy3까지 순차적으로 실행되기 때문에
        //Enemy1 실행 중 다음 함수가 실행될 우려가 있습니다.
        //(correct 키를 눌러도 다음 함수에선 incorrect키로 인식되기 때문에 점수가 깎일 수 있음)

        Enemies[currentEnemy].SendMessage("ProgressEnemy");
    }

    public void BackwardMovement()
    {
        for (int i = currentEnemy; i < currentEnemyCount; i++)
        {
            if (Enemies[i].GetComponent<Enemy1>())
                Enemies[i].GetComponent<Enemy1>().BackwardMovement();

            if (Enemies[i].GetComponent<Enemy2>())
                Enemies[i].GetComponent<Enemy2>().BackwardMovement();

            if (Enemies[i].GetComponent<Enemy3>())
                Enemies[i].GetComponent<Enemy3>().BackwardMovement();
        }
    }
}