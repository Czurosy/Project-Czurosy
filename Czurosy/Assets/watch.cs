using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class watch : MonoBehaviour
{
    public TMP_Text text;
    public float hour;
    public float minute;
    public float timer;
  

    private void Start()
    {
        text.SetText(hour + ":" + minute);

    }

    void Update()
    {
        timer += Time.deltaTime;
        text.SetText(hour + ":" + minute);
        if(timer >= 1)
        {
            minute += 1;
            timer = 0;
        }
       
        if(minute >= 60)
        {
            minute = 0;
            hour += 1;
        }
    }
}
