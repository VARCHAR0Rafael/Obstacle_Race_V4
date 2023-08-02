using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    [SerializeField] float yValue = 0f;
    [SerializeField] float moveSpeed = 12f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * moveSpeed* Time.deltaTime;
        //transform.Translate(xValue, yValue, zValue);

        transform.Translate(xValue, yValue, zValue);
    }
}
