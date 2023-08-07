using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer rendererView;
    Rigidbody gravity;
    [SerializeField]float timePassed = 5f;
    void Start()
    {
        InvisibleStart();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timePassed)
        {
            rendererView.enabled = true;
            gravity = GetComponent<Rigidbody>();
            gravity.useGravity = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hitted";
        }
    }

    void InvisibleStart()
    {
        rendererView = GetComponent<MeshRenderer>();
        rendererView.enabled = false;
    }

}
