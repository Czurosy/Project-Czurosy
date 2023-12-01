using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Logical : MonoBehaviour
{
    private float time = 0.0f;
    public float interpolationPeriod = 0.1f;
    public GameObject enemy;
    void Start()
    {

    }


    void Update()
    {
        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {
            time = 0.0f;
            float lowestPoint = transform.position.y - 100;
            float highestPoint = transform.position.y + 100;
            Instantiate(enemy, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z), transform.rotation);
        }

    }
}
