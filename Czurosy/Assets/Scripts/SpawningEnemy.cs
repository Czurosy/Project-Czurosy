using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Logical : MonoBehaviour
{
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