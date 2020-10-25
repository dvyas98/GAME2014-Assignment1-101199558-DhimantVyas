/*/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Created BY :
Dhimant Vyas
101199558
Game Programming (T163)
DVSquareProductions.

Player Movement with Joystick and Tilt of the Spaceship using Euler Principle
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using UnityEngine;
using UnityEngine.Experimental.XR;
using UnityEngine.Events;
using UnityEngine.UI;



[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;

}

public class PlayerMove : MonoBehaviour
{
    private Transform _transform;
    public GameController gameController;
    public CharacterController controller;
    public EnemyManager enemyManager;
    public BulletManager bulletManager;
    public float _runSpeed = 10.0f;
    public float tilt = 3.0f;
    public Joystick joystick;
    public Boundary boundary;
    public Fire firebutton;
    public Vector3 positionBullet;
    public Vector3 positionEnemy;

   

     void Start()
    {
    }

    void Update()
    {
        float moveHorizontal = joystick.Horizontal;
        float moveVertical = joystick.Vertical;
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        GetComponent<Rigidbody>().velocity = movement * _runSpeed;  //Get Rigid body of the Spaceship and move it to the run Speed.
        GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),  // Clamping the position of the spaceship to let it only move inside the Game Boundary.   X Component
            Mathf.Clamp(GetComponent<Rigidbody>().position.y, boundary.yMin, boundary.yMax),  //                                                                                        Y Component
            0.0f                                                                              //                                                                                        Z Component
        );
        GetComponent<Rigidbody>().rotation = Quaternion.Euler(-180,GetComponent<Rigidbody>().velocity.x*-tilt,0.0f);  // For the Tilting effect of the Player.
       
       
            _FireBullet();
   
        
       
    }
    public void _FireBullet()
    {
        positionBullet.x = transform.position.x-0.2f; 
        positionBullet.y = transform.position.y + 0.9f;
        positionBullet.z = transform.position.z;
        // delay bullet firing 
        if (Time.frameCount % 30 == 0 && bulletManager.HasBullets())
        {
            bulletManager.GetBullet(positionBullet);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ship_1"|| other.gameObject.name == "Ship_2"|| other.gameObject.name == "Ship_1(Clone)"|| other.gameObject.name == "Ship_2(Clone)")
        {
            GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            Application.LoadLevel("Lose");
   
        }
    }

    }
