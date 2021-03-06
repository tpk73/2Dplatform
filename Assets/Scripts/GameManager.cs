using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int highScore = 0;
    public int numLivesLeft = 3;

    void Awake()
    {
        GameObject[] obs = GameObject.FindGameObjectsWithTag("MrManager");

        if (obs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
