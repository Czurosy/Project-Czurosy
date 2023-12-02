using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IfTouchZombie : MonoBehaviour
{
    private bool isAlive = true;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("sdsds");
        if (collision.gameObject.tag == "Zombie")
        {
            Debug.Log("Ep");
        }
    }
}
