using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    float speed = 10;
    float timer = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb.velocity = new Vector3(0,0,1) * speed;
        
        timer += Time.deltaTime;
        if(timer > 3)
            Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        else
        {
            //Continuar
        }
    }
}
