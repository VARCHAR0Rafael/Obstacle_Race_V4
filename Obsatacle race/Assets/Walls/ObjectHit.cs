using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        CollisionActions();
    }

    void CollisionActions()
    {
        //Debug.Log("Wall Collision");
        GetComponent<MeshRenderer>().material.color = Color.gray;
    }

}
