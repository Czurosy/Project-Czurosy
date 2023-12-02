using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Logical : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public int countKill;
    public int fala;
    public int[] numberOfZombie;
    private float offset = 10.0f;
    private float posX;
    private float posY;
    void Start()
    {
        countKill = 0;
        int[] numberOfZombie = { 6, 10, 16, 20, 30, 100 };
        fala = 0;

        if (fala != 5)
        {
            for (int i = 0; i < numberOfZombie[fala]; i++)
            {
                float[] highestPoint = { -9.0f, 10.0f };
                float[] lowestPoint = { -15.0f, 3.0f };
                do
                {
                    posX = Random.Range(highestPoint[0], highestPoint[1]);
                    posY = Random.Range(lowestPoint[0], lowestPoint[1]);
                } while (true/*(posX - player.transform.position.x < offset || player.transform.position.x - posX < offset) && (posY - player.transform.position.y < offset || player.transform.position.y - posY < offset)*/);
                Instantiate(enemy, new Vector2(posX, posY), transform.rotation);
            }
        }
    }
    public void zombieIsShot()
    {
        countKill++;
        Debug.Log(countKill);
    }
}
