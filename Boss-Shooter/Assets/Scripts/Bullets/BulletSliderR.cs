﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSliderR : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {

        

	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(new Vector2(0, -(speed * Time.deltaTime)));

        

    }
}
