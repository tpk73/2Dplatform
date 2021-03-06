using UnityEngine;

public class BulletScript : MonoBehaviour
{
    GameManager manny;

    void Start()
    {
        manny = GameObject.FindGameObjectWithTag("MrManager").GetComponent<GameManager>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BadGuy")
        {
            manny.highScore = manny.highScore + 2;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "ground")
        {
            Destroy(gameObject);
        }
    }
}
