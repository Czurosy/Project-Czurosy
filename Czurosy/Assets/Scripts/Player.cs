using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float runningSpeed;
    private Vector2 mousePos;
    private float horizontal;
    private float vertical; 
     public Rigidbody2D rb = new Rigidbody2D();
    public TMP_Text text;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firingPoint;
    [Range(0.1f, 1f)]
    [SerializeField] private float pistolFireRate = 0.5f;
    [Range(0.1f, 1f)]
    [SerializeField] private float shootgunFireRate = 1f;
    [Range(0f, 30f)]
    [SerializeField] private float pistolAmmo = 20;
    [Range(0f, 10f)]
    [SerializeField] private float shootgunAmmo = 5;
    private float maxShotgunAmmo = 10;
    private float maxPistolAmmo = 30;
    public SpriteRenderer renderer;
    private float pistolshootTimer;
    private float shootgunShootTimer;
    public float selectedWeapon = 2;
    public Sprite pistolet;
    public Sprite shotgun;
    
    
    void Update()
    {
        

        if (selectedWeapon == 2 && shootgunAmmo == 0)
        {
            text.color = Color.red;
            text.SetText(shootgunAmmo + "/" + maxShotgunAmmo);
        }else if(selectedWeapon == 2){
            text.color = Color.black;
            text.SetText(shootgunAmmo + "/" + maxShotgunAmmo);
        }
        else if( selectedWeapon == 1 && pistolAmmo == 0)
        {
            text.color= Color.red;
            text.SetText(pistolAmmo + "/" + maxPistolAmmo);
        }else if( selectedWeapon == 1)
        {
            text.color = Color.black;
            text.SetText(pistolAmmo + "/" + maxPistolAmmo);
        }
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg - 90f;
        transform.localRotation = Quaternion.Euler(0,0,angle);
        if(pistolshootTimer > 0)
        {
            pistolshootTimer -= Time.deltaTime; 
        }
        if(shootgunShootTimer > 0)
        {
            shootgunShootTimer -= Time.deltaTime;  
        }
        ShootingControl();

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            switch(selectedWeapon)
            {
                case 1:
                    renderer.sprite = shotgun;
                    selectedWeapon = 2;
                    break;
                case 2:
                    
                    renderer.sprite = pistolet;
                    selectedWeapon = 1;
                    break;
            }
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontal,vertical, 0).normalized * runningSpeed;
    }

    

    private void pistolShoot() {
        Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation);

    }
    private void shootgunShoot()
    {
        Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation);
        Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation * Quaternion.Euler(new Vector3(0,0,-7)));
        Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation * Quaternion.Euler(new Vector3(0,0,7)));

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ammoBox")
        {
            pistolAmmo +=10;
            shootgunAmmo += 5;
            Destroy(collision.gameObject, 0);
            Console.Write("kolizja");
        }
    }
    private void ShootingControl()
    {
        switch (selectedWeapon)
        {
            case 1:
                if (Input.GetMouseButtonDown(0) && pistolshootTimer <= 0 && pistolAmmo > 0)
                {
                    pistolShoot();
                    
                    pistolshootTimer = pistolFireRate;
                    pistolAmmo -= 1;
                }
                break;
            case 2:
                if (Input.GetMouseButtonDown(0) && shootgunShootTimer <= 0 && shootgunAmmo > 0)
                {
                    shootgunShoot();
                    
                    shootgunShootTimer = shootgunFireRate;
                    shootgunAmmo -= 1;
                }
                break;

        }
    }
}


