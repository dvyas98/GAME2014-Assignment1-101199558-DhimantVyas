/*/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Created BY :
Dhimant Vyas
101199558
Game Programming (T163)
DVSquareProductions.

Button Behavoiour
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/
///

using System;
using System.Collections;
using UnityEngine;

[System.Serializable]
public class EnemyManager : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public int enemyCount;              //Movement of our Enemy and Spawning new enemies after a Time.
    public Vector3 spawnposval;
    public float spawnWait;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
     }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            for (int i = 0; i < enemyCount; i++)
            {
                Vector3 spawnPos = new Vector3(UnityEngine.Random.Range(-spawnposval.x, spawnposval.x), spawnposval.y, spawnposval.z);
                Quaternion q1 = new Quaternion();
                q1.x = 0;
                q1.y = 0;
                q1.z = 180;
                Quaternion q2 = new Quaternion();
                q2.x = 60;
                q2.y = 0;
                q2.z = 60;
                Instantiate(enemy1, spawnPos, q1);
                Instantiate(enemy2, spawnPos, q2);
                yield return new WaitForSeconds(spawnWait);

            }
        }

    }
}