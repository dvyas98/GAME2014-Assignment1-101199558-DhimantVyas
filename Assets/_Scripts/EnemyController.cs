/*/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Created BY :
Dhimant Vyas
101199558
Game Programming (T163)
DVSquareProductions.

EnemyController
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;
    public float verticalSpeed;
    public float horizontalBoundary;
    public float verticalBoundary;
    public EnemyManager enemyManager;
    public float direction;

    // Update is called once per frame
    void Update()                 //Moving of Our Enemy and Playing the sound when it Hits Something.
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed * direction * Time.deltaTime, -verticalSpeed  * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.x >= horizontalBoundary)             ///Checking Boundry left and Right to change the Direction.
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.x <= -horizontalBoundary)
        {
            direction = 1.0f;
        }
        if (transform.position.y < verticalBoundary)
        {
            
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name);

        if (other.gameObject.name == "Bullet_Main" || (other.gameObject.name == "Bullet_Main(Clone)"))
        {
            GetComponent<AudioSource>().Play();
            Destroy(gameObject);                     //Hit Something?
            Debug.Log("EnemyHit");
            
        }
        if (other.gameObject.name == "Luminaris Starship")
        {
            Destroy(gameObject);
            Debug.Log("PlayerHit");

           
        }


    }

}
