using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Logical : MonoBehaviour
{
    private float time = 0.0f;
    private float interpolationPeriod = 10.0f;
    public GameObject enemy;
    public int fala;
    public int[] numberOfZombie;
    void Start()
    {
        int[] numberOfZombie = { 6, 10, 16, 20, 30, 100 };
        fala = 0;

        time += Time.deltaTime;
        if(fala != 5)
        {
            for (int i = 0; i < numberOfZombie[fala]; i++) {
                float[] highestPoint = { -9.0f, 10.0f };
                float[] lowestPoint = { -15.0f, 3.0f };
                Instantiate(enemy, new Vector2(Random.Range(highestPoint[0], highestPoint[1]), Random.Range(lowestPoint[0], lowestPoint[1])), transform.rotation);
            }
        }
    }


    void Update()
    {

    }
}
