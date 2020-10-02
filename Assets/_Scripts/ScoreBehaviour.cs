using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBehaviour : MonoBehaviour
{
    public Text Score;
    public float ScoreAmount;
    public float Increase;

    // Start is called before the first frame update
    void Start()
    {
        ScoreAmount = 0.0f;
        Increase = 1.0f;

    }

    // Update is called once per frame
    void Update()
    {
        Score.text = (int) ScoreAmount + ".";
        ScoreAmount += Increase * Time.deltaTime;
    }
}
