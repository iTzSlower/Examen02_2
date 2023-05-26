using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    float limit = 19;
    [SerializeField]
    float timer = 0;
    float maxtimer;
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > maxtimer)
        {
            GameObject g = Instantiate(prefab);
            g.transform.position = new Vector3 (Random.Range(-limit,limit), transform.position.y, transform.position.z);
            timer = 0;
            maxtimer = Random.Range(2,5);
        }
    }
}
