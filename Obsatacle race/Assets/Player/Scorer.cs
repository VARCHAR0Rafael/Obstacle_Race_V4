using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Ground")
        {
            if (collision.gameObject.tag != "Hitted")
            {
                score += 1;
                Debug.Log("You hit something this times: " + score);
                //Debug.Log(collision.gameObject.name);

            }
        }
    }
}
