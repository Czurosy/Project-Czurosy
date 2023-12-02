using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class SpawningEnemy : MonoBehaviour
{
    public float time;
    public Logical logic;
    public GameObject enemy;
    public float speed;

    private float interpolationPeriod = 10.0f;
    private GameObject player;
    private Rigidbody2D rb;

    private float distance;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logical>();
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;

        if (distance < 40)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
    }
}


