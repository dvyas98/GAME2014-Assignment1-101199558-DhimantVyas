/*/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Created BY :
Dhimant Vyas
101199558
Game Programming (T163)
DVSquareProductions.

Bullet Factory
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletFactory : MonoBehaviour
{
    [Header("BulletTypes")]
    public GameObject regularBullet;


    public GameObject createBullet()   //Just Doing One thing Making the BUllet. Similar to a factory which has just one function .
    {
        GameObject tempBullet = null;       
        tempBullet=Instantiate(regularBullet);
        tempBullet.GetComponent<BulletController>().damage = 10;
        tempBullet.transform.parent = transform;
        tempBullet.SetActive(false);

        return tempBullet;
    }
}
