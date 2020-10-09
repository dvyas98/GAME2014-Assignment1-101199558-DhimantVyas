using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public float verticalSpeed;

    // Update is called once per frame
    void Update()
    {
        _Move();
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

    private void _CheckBounds()
    {
        // Chcek bottom bounds.
        if (transform.position.y <= -10.0f)
        {
            _Reset();
        }
    }

}
