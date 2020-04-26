﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;

    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

    }

}