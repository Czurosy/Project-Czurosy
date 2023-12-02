using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IfTouchZombie : MonoBehaviour
{
    private bool isAlive = true;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("It didnd Worked");
        if (hit.gameObject.tag == "Zombie" )
        {
            Debug.Log("It Worked");

            isAlive = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ep");
    }
}
