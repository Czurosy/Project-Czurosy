using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Watch : MonoBehaviour
{
    public float godzina = 14;
    public float minuta = 0;
    public TMP_Text text;
    private float timer = 0;
    void Start()
    {
       text.SetText(godzina + ":" + minuta); 
    }


    private void FixedUpdate()
    {
        text.SetText(godzina + ":" + minuta);
        if (timer >= 3)
        {
            minuta += 1;
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }

        if(minuta >= 60)
        {
            minuta = 0;
            godzina += 1;
        }
    }
}
