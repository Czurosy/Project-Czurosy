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
    private float offset = 3.0f;
    private float posX;
    private float posY;
    private float[] highestPoint;
    private float[] lowestPoint;
    void Start()
    {
        countKill = 0;
        int[] numberOfZombie = {2, 3, 4, 5, 6, 0 };
        fala = 0;

        if (fala != 5)
        {
            countKill = 0;
            for (int i = 0; i < numberOfZombie[fala]; i++)
            {
                float[] highestPoint = { -9.0f, 10.0f };
                float[] lowestPoint = { -15.0f, 3.0f };
                posX = Random.Range(highestPoint[0], highestPoint[1]);
                posY = Random.Range(lowestPoint[0], lowestPoint[1]);
                while((player.transform.position.x + offset > posX && player.transform.position.x - offset < posX) && (player.transform.position.y + offset > posY && player.transform.position.y - offset < posY))
                {
                    posX = Random.Range(highestPoint[0], highestPoint[1]);
                    posY = Random.Range(lowestPoint[0], lowestPoint[1]);
                }
               // if (player.transform.position.x + offset > posX && player.transform.position.x - offset < posX)

                    //} while (false/*(posX - player.transform.position.x < offset || player.transform.position.x - posX < offset) && (posY - player.transform.position.y < offset || player.transform.position.y - posY < offset)*/);
                    Instantiate(enemy, new Vector2(posX, posY), transform.rotation);
            }
        }

        Debug.Log(enemy);
        /*(if((enemy.transform.position.x > highestPoint[1] || enemy.transform.position.x < highestPoint[0]) && (enemy.transform.position.y > lowestPoint[1] || enemy.transform.position.y < lowestPoint[0]))
        {
            Debug.Log("NIC");
            Object.Destroy(enemy);
            countKill++;
        }*/
    }

    public void zombieIsShot()
    {
        countKill++;
    }
}
