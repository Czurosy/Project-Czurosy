using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfTouchZombie : MonoBehaviour
{
    private bool isAlive = true;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Zombie" )
        {
            Debug.Log("It Worked");

            isAlive = false;
        }
    }
}
