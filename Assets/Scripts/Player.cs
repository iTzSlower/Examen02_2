using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public int life;
    public GameObject player;

    public int deaths;
    public int wins;

    Rigidbody rb;
    [SerializeField]
    float speed;
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    TMP_Text texTime;
    float timeLimit = 60;
    [SerializeField]
    GameObject pan, time, win;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(timeLimit > 0) {
            texTime.text = "Time: " + Mathf.Round(timeLimit);
            timeLimit -= Time.deltaTime;
            time.SetActive(true);
        }
        else {
            time.SetActive(false);
            win.SetActive(true);
            player.GetComponent<Player>().wins += 1;
        }

        if(life== 0)
        {
            win.SetActive(true);
            player.GetComponent<Player>().deaths += 1;
        }
            

        float h = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector3(h,0,0) * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject g = Instantiate(prefab);
            g.transform.position = transform.position + new Vector3(0,0,1);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            life-=1;
        }
    }
}
