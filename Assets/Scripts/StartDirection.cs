using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDirection : MonoBehaviour
{
    Rigidbody rb;
    bool active = true;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.velocity = new Vector3(1,1,0);
        rb.velocity = rb.velocity * 4;

    }
    private void Update()
    {
        Physics.gravity = new Vector3(2, 2, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision != null)
        {
            rb.velocity = new Vector3(rb.velocity.x * 1.05f, rb.velocity.y, rb.velocity.z);
            rb.velocity =rb.velocity * 1.05f;
        }
    }
}
