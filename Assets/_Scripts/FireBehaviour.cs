using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehaviour : MonoBehaviour
{
    public GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void _FireBullet()
    {
        // delay bullet firing - every 40 frames
        if (Time.frameCount % 60 == 0)
        {
            gameController.GetBullet(transform.position);
        }
    }
}
