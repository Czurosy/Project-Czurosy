using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class NumberOfFala : MonoBehaviour
{
    public Logical logic;
    public Text txt;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logical>();

    }

    // Update is called once per frame
    void Update()
    {
        txt.text = logic.fala+ 1 + "";
    }
}
