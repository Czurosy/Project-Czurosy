using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class SpawningEnemy : MonoBehaviour
{
    public Logical logic;
    public GameObject player;
    public GameObject enemy;
    private Rigidbody2D rb;
    public float speed;
    private float time = 0.0f;
    private float interpolationPeriod = 10.0f;
    float[] highestPoint = { -9.0f, 10.0f };
    float[] lowestPoint = { -15.0f, 3.0f };

    private float distance;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logical>();
        rb = this.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;


            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);

    }
}

/*{
        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {
            time = 0.0f;
            float lowestPoint = transform.position.y - 30;
            float highestPoint = transform.position.y + 30;
            Instantiate(enemy, new Vector2(Random.Range(lowestPoint, highestPoint), Random.Range(lowestPoint, highestPoint)), transform.rotation);
        }
 */