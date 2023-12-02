using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IfTouchZombie : MonoBehaviour
{
    private bool isAlive = true;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            isAlive = false;
            Debug.Log("Koniec");
            SceneManager.LoadSceneAsync(2);
        }
    }
}
