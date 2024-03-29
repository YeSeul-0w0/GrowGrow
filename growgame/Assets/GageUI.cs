﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GageUI : MonoBehaviour {

    GameObject Sungage;
    GameObject Watergage;

    public Text waterpoint;
    public Text sunpoint;
    public int suncount = 0;
    public int watercount = 0;

    int Wcount = 0;
    int Scount = 0;

    int Water = 0;
    int Sun = 0;
    // Use this for initialization
    void Start () {
        this.Sungage = GameObject.Find("Sungage");
        this.Watergage = GameObject.Find("Watergage");
        waterpoint = GameObject.Find("WaterIcon_text").GetComponent<Text>();
        waterpoint.text = watercount + " / " + Wcount;

        sunpoint = GameObject.Find("SunIcon_text").GetComponent<Text>();
        sunpoint.text = suncount + " / " + Scount;

    }
	void Update()
    {
        if (SoilStauts.change_s == 0)
        {
            Wcount = 1;
            Scount = 1;
        }
        else if (SoilStauts.change_s == 1 || SoilStauts.change_s == 2)
        {
            Wcount = 3;
            Scount = 2;
        }
        WaterIconCount();
        SunIconCount();
        Water = GetPoint.waterpoint - watercount * 100;
        Sun = MinGetPoint.sunpoint - suncount * 50;
        if (Water >= 100)
        {
            this.Watergage.GetComponent<Image>().fillAmount = 1.0f;
        }

        if (Sun >= 50)
        {
            this.Sungage.GetComponent<Image>().fillAmount = 1.0f;
        }

        this.Sungage.GetComponent<Image>().fillAmount = Sun / 50f;
        this.Watergage.GetComponent<Image>().fillAmount = Water / 100f;
    }

    public void WaterIconCount()
    {
        int temp = GetPoint.waterpoint;
        if (temp >= 100)
        {            
            watercount = 1;
        }
        if (temp >= 200)
        {
            watercount = 2;
        }

        if (temp >= 300)
        {
            watercount = 3;
        }

        if (temp >= 400)
        {
            watercount = 4;
        }
        waterpoint.text = watercount + " / " + Wcount;
    }

    public void SunIconCount()
    {
        int temp2 = MinGetPoint.sunpoint;

        if (temp2 >= 50)
        {
            suncount = 1;
        }

        if (temp2 >= 100)
        {
            suncount = 2;
        }

        if (temp2 >= 150)
        {
            suncount = 3;
        }
        sunpoint.text = suncount + " / " + Scount;
    }
}