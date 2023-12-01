using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Logical : MonoBehaviour
{
    private float time = 0.0f;
    public float interpolationPeriod = 1f;
    public GameObject enemy;
    public Transform player;
    void Start()
    {

    }


    void Update() { 
        Vector3 direction = player.position - transform.position;
    
    }
}

/*{
        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {
            time = 0.0f;
            float lowestPoint = transform.position.y - 30;
            float highestPoint = transform.position.y + 30;
            Instantiate(enemy, new Vector2(Random.Range(lowestPoint, highestPoint), Random.Range(lowestPoint, highestPoint)), transform.rotation);
        }
 */