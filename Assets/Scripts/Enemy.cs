using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody rb;
    float speed = 5;
    GameObject look;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        look = GameObject.FindGameObjectWithTag("Player");
    }
    void Move()
    {
        transform.LookAt(look.transform);
        Vector3 a = transform.forward;
        rb.velocity = a * speed;
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision != null)
        {
            if (look != null) {
                Move();
                if (collision.collider.CompareTag("Player"))
                    Destroy(this.gameObject);
            }
        }
    }
}
