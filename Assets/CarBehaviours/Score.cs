using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;
    public float timer = 10f;
    public int highScore = 2;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
    }

    public void AddScore()
    {
        if (timer > 0f)
        {
            score++;
            print("Score: " + score);
            if (score > highScore)
            {
                highScore = score;
                print("You set a new high score!");
            }
        }
        else
        {
            print("Out of time!");
        }
    }
}
