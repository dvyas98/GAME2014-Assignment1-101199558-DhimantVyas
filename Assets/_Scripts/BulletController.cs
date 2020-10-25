/*/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Created BY :
Dhimant Vyas
101199558
Game Programming (T163)
DVSquareProductions.

Bullet Controller.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float verticalSpeed;   //Defining the Characterstics of our Bullet Here.
    public float verticalBoundary;
    public BulletManager bulletManager;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();                 //Movement and Bounds of Bullet can be checked Here. If bullet is out of Bunds then Start spawn at teh Player location and Continue the circle.
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed, -0.82f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (transform.position.y > verticalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
         Debug.Log(other.gameObject.name);

        if (other.gameObject.name != "Luminaris Starship")
        {                                                              ///WHat Did the Bullet Hit?  Thats Important!
            Debug.Log("BulletReturned");
            bulletManager.ReturnBullet(gameObject);
        }


    }

    public int ApplyDamage()
    {
        return damage;
    }
}

