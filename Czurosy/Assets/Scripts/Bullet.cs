using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField] private float speed = 10f;
    [Range(1, 10)]
    [SerializeField] private float lifeTime = 3f;
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed;
        Console.Write("Kolizja");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Console.Write("Kolizja");
        if(collision.gameObject.tag == "Niszczenie"){
            Destroy(gameObject,0);
            Destroy(collision.gameObject,0); 
        }
    }
}
