using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeFall : MonoBehaviour
{
    public Rigidbody rB;

    private float t = 0.0f;
    private bool moving = false;

    void Start()
    {
        rB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rB.velocity = new Vector3(0, -1, 0);
        moving = true;
    }

}
