using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Vector2 moveForce;
    Vector2 PlayerInput;
    public float runningSpeed;
    private Vector2 mousePos;
    private float horizontal;
    private float vertical; 
     public Rigidbody2D rb = new Rigidbody2D();
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firingPoint;
    [Range(0.1f, 1f)]
    [SerializeField] private float fireRate = 0.5f;
    private float shootTimer;
    public float hp = 1;
    
    
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg - 90f;
        transform.localRotation = Quaternion.Euler(0,0,angle);
        if (Input.GetMouseButtonDown(0) && shootTimer <= 0 )
        {
            Shoot();
            shootTimer = fireRate;
        }
        else
        {
            shootTimer -= Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal,vertical).normalized * runningSpeed;
    }

    private void Shoot() {
        Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation);

    }
}