/*/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Created BY :
Dhimant Vyas
101199558
Game Programming (T163)
DVSquareProductions.

Background Manager
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public float verticalSpeed;

    // Update is called once per frame
    void Update()
    {
        _Move();                            //Movements of our Scrolling Background.
        _CheckBounds();
    }

    private void _Move()
    {
        var newPosition = new Vector3(0.0f, verticalSpeed, 0.0f);
        transform.position -= newPosition;
    }

    private void _Reset()
    {
        transform.position = new Vector3(0.0f, 10.0f, 0.0f);
    }

    private void _CheckBounds()          //Just like Bullet this also changes its spawn location according to Bounds.
    {
        // Chcek bottom bounds.
        if (transform.position.y <= -10.0f)
        {
            _Reset();
        }
    }

}
