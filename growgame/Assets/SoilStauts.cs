﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoilStauts : MonoBehaviour {

    public static int change_s = 0;
    public static SoilStauts instance;

    // Use this for initialization
    void Start () {
		
	}
	
    public void change()
    {
        if (GetPoint.waterpoint >= 0 && MinGetPoint.sunpoint >= 0)
        {
            change_s = 0;
        }
        if (GetPoint.waterpoint >= 100 && MinGetPoint.sunpoint >= 50)
        {
            change_s = 1;
        }

        if (GetPoint.waterpoint >= 300 && MinGetPoint.sunpoint >= 100)
        {
            change_s = 2;
        }
    }
	// Update is called once per frame
	void Update () {

        change();
	}
}
