using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    GameManager manny;

    void Start()
    {
        manny = GameObject.FindGameObjectWithTag("MrManager").GetComponent<GameManager>();
        //manny = (GameManager)FindObjectOfType(typeof(GameManager));
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") 
        {
            manny.highScore ++;
            Destroy(gameObject);
        }
    }
}
