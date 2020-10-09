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

    // Update is called once per frame
    public float _runSpeed = 10.0f;
    public float tilt = 3.0f;
    public Joystick joystick;
    public Boundary boundary;
    public 

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


    }

   
}
