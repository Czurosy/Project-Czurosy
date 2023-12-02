using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackArea : MonoBehaviour
{
    void Start()
    {
        Debug.Log("uderzenie");
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "niszczenie")
        {
            Destroy(collision.gameObject,0);
        }
    }
}
