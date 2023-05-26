using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public int life;
    Rigidbody rb;
    [SerializeField]
    float speed;
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    TMP_Text text;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector3(h,0,0) * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject g = Instantiate(prefab);
            g.transform.position = transform.position + new Vector3(0,0,1);
        }
    }
}
