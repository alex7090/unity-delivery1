﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart;
    public Text textBox;
   
    // Use this for initialization
    void Start()
    {
        textBox.text = timeStart.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += Time.deltaTime;
        textBox.text = timeStart.ToString("F2");
    }
}