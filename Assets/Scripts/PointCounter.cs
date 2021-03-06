using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public Text pointScoreCounter;
    public Text numOfLivesCount;

    GameManager manny;
    void Start()
    {
        manny = GameObject.FindGameObjectWithTag("MrManager").GetComponent<GameManager>();
    }

    void Update()
    {
        numOfLivesCount.text = "Lives: " + manny.numLivesLeft;
        pointScoreCounter.text = "Score: " + manny.highScore;
    }
}
