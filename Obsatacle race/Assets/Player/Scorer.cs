using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        
        ScoreCounter();
    }

    void ScoreCounter()
    {
        score += 1;
        Debug.Log("You hit something this times: " + score);
    }
}
