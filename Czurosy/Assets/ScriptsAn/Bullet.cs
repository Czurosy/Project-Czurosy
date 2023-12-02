using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
<<<<<<< HEAD:Czurosy/Assets/Scripts/Bullet.cs
    [Range(1, 20)]
=======
    private Logical logic;
    [Range(1, 10)]
>>>>>>> origin/Fala1Done:Czurosy/Assets/ScriptsAn/Bullet.cs
    [SerializeField] private float speed = 10f;
    [Range(1, 10)]
    [SerializeField] private float lifeTime = 3f;
    public Rigidbody2D rigidBody;
    void Start()
    {
<<<<<<< HEAD:Czurosy/Assets/Scripts/Bullet.cs
        rigidBody = GetComponent<Rigidbody2D>();
=======
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logical>();

        rb = GetComponent<Rigidbody2D>();
>>>>>>> origin/Fala1Done:Czurosy/Assets/ScriptsAn/Bullet.cs
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = transform.up * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Console.Write("Kolizja");
<<<<<<< HEAD:Czurosy/Assets/Scripts/Bullet.cs
        if (collision.gameObject.tag == "Zombie")
        {
            Destroy(gameObject, 0);
            Destroy(collision.gameObject, 0);
=======
        if(collision.gameObject.tag == "Zombie"){
            Destroy(gameObject,0);
            Destroy(collision.gameObject,0);
            logic.zombieIsShot();
>>>>>>> origin/Fala1Done:Czurosy/Assets/ScriptsAn/Bullet.cs
        }
    }
}
