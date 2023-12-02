using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Logical logic;
    [Range(1, 40)]
    [SerializeField] private float speed = 10f;
    [Range(1, 10)]
    [SerializeField] private float lifeTime = 3f;
    public Rigidbody2D rb;
    [SerializeField] private ParticleSystem hitParticlePrefab;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logical>();

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
        if(collision.gameObject.tag == "Zombie")
        {
            Instantiate(hitParticlePrefab, transform.position, Quaternion.identity);
            Destroy(collision.gameObject,0);
            logic.zombieIsShot();
            Destroy(gameObject, 0);
        }
        if (collision.gameObject.tag == "wall")
        {
            Destroy(gameObject,0);
        }
    }
}
