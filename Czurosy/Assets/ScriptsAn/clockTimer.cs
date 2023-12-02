using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockTimer : MonoBehaviour
{
    public float czasFali = 180;
    public float timer;
    public float godzina;
    void Start()
    {
        godzina = 14;
        timer = godzina;

    }

    
    void Update()
    {
        czasFali -= 1 * Time.deltaTime;
     
    }
}
