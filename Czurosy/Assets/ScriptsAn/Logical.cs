using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Logical : MonoBehaviour
{
    public float interpolationPeriod;
    public GameObject enemy;
    public GameObject ammo;
    public GameObject player;
    private int numberOfAmmo = 3;
    public int countKill = 0;
    public int fala = 0;
    int numberOfZombie = 30;
    private float offset = 3.0f;
    private float posX;
    private float posY;
    public GameObject spawnArea;  
    private float time = 0.0f;
    public float offsetMiddle = 15f;
    public GameObject middleObject;
    private watch watchObject;
    private float startingHour;
    void Start()
    {
        watchObject = GameObject.FindGameObjectWithTag("watch").GetComponent<watch>();
        startingHour = watchObject.hour;
        countKill = 0;
            for (int i = 0; i < numberOfZombie; i++)
            {
                posX = Random.Range(middleObject.transform.position.x - offsetMiddle, middleObject.transform.position.x  + offsetMiddle);
                posY = Random.Range(middleObject.transform.position.y - offsetMiddle, middleObject.transform.position.y + offsetMiddle);
            Debug.Log(posX + ", " + posY);
                while ((player.transform.position.x + offset > posX && player.transform.position.x - offset < posX) && (player.transform.position.y + offset > posY && player.transform.position.y - offset < posY))
            {
                posX = Random.Range(middleObject.transform.position.x - offsetMiddle, middleObject.transform.position.x + offsetMiddle);
                posY = Random.Range(middleObject.transform.position.y - offsetMiddle, middleObject.transform.position.y + offsetMiddle);
            }
                // if (player.transform.position.x + offset > posX && player.transform.position.x - offset < posX)

                //} while (false/*(posX - player.transform.position.x < offset || player.transform.position.x - posX < offset) && (posY - player.transform.position.y < offset || player.transform.position.y - posY < offset)*/);
                Instantiate(enemy, new Vector2(posX, posY), transform.rotation);
            }
        

        Debug.Log(enemy);
        /*(if((enemy.transform.position.x > positionX[1] || enemy.transform.position.x < positionX[0]) && (enemy.transform.position.y > positionY[1] || enemy.transform.position.y < positionY[0]))
        {
            Debug.Log("NIC");
            Object.Destroy(enemy);
            countKill++;
        }*/
    }

    void FixedUpdate()
    {
        if (watchObject.hour > startingHour)
        {
            SceneManager.LoadScene(2);

        }
        if (countKill == numberOfZombie + 1)
        {
            Debug.Log("Wygrana");
        }
        
        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {
            
            for (int i = 0; i < numberOfZombie; i++)
            {
               
                posX = Random.Range(middleObject.transform.position.x - offsetMiddle, middleObject.transform.position.x + offsetMiddle);
                posY = Random.Range(middleObject.transform.position.y - offsetMiddle, middleObject.transform.position.y + offsetMiddle);
                Debug.Log(posX + ", " + posY);
                while ((player.transform.position.x + offset > posX && player.transform.position.x - offset < posX) && (player.transform.position.y + offset > posY && player.transform.position.y - offset < posY))
                {
                    posX = Random.Range(middleObject.transform.position.x - offsetMiddle, middleObject.transform.position.x + offsetMiddle);
                    posY = Random.Range(middleObject.transform.position.y - offsetMiddle, middleObject.transform.position.y + offsetMiddle);
                }
                // if (player.transform.position.x + offset > posX && player.transform.position.x - offset < posX)

                //} while (false/*(posX - player.transform.position.x < offset || player.transform.position.x - posX < offset) && (posY - player.transform.position.y < offset || player.transform.position.y - posY < offset)*/);
                Instantiate(enemy, new Vector2(posX, posY), transform.rotation);
            }
            if(numberOfAmmo != 0) { 
                for(int i = 0;i < numberOfAmmo;i++) { 
                    posX = Random.Range(player.transform.position.x - offset, player.transform.position.x + offset);
                    posY = Random.Range(player.transform.position.y - offset, player.transform.position.y + offset);
                    Instantiate(ammo, new Vector2(posX, posY), transform.rotation);
                }
                numberOfAmmo--;
            }
            time = 0.0f;
        }
    }


    
    public void zombieIsShot()
    {
        countKill++;
    }

}
