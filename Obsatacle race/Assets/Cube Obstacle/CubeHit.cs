using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        CollisionActions();
    }

    void CollisionActions()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
