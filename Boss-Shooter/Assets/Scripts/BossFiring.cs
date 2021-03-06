﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFiring : MonoBehaviour
{

    public GameObject bulletprefab;
    public GameObject spread1prefab;
    public GameObject spread2prefab;
    public GameObject spread3prefab;
    public GameObject SliderRprefab;
    public GameObject BurstBombprefab;
    public GameObject Crazyshotprefab;
    public int test;
    private float AttackDelay; 
    private List<int> AttackQueue = new List<int>();
    private int attack;
    private Rigidbody2D BulletRB;
    private int testfire;
    private int sliderrandom;


    // Use this for initialization
    void Start()
    {


        testfire = 0;
     
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("test_fire"))
        {
            testfire = (testfire + 1) % 2;

        }


        if (AttackDelay >= 2)
        {
            if (testfire == 0)

            {
                attack = Random.Range(0, 2);

                //Debug.Log(attack);

                if (attack == 0)
                    StraightShot();

                if (attack == 1)
                    SpreadShot();

                AttackDelay = 0;

                

            }
        }

        if (testfire == 1)
        {
            if (Input.GetButtonDown("test1"))
            {
                StraightShot();
            }

            if (Input.GetButtonDown("test2"))
            {
                SpreadShot();
            }

            if (Input.GetButtonDown("test3"))
            {
                SlideShotR();

                SlideShotR();

                SlideShotR();

                SlideShotR();

                SlideShotR();
            }

            if (Input.GetButtonDown("test4"))
            {
                BurstBomb();
            }

            if (Input.GetButtonDown("test5"))
            {
                CrazyShot();
            }

        }

        AttackDelay += 1 * Time.deltaTime;


    }

    void StraightShot()
    {

        GameObject Bullet;

        Bullet = (Instantiate(bulletprefab, transform.position, transform.rotation)) as GameObject;

        


        //Bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, bullet_speed*Time.deltaTime));

        //Bullet.transform.Translate(Vector2(0, bullet_speed));

        //Rigidbody Bullet = (Rigidbody)Instantiate(bulletprefab, transform.position + transform.forward, transform.rotation);
        //Bullet.GetComponent<Rigidbody2D>().AddForce(transform.forward * bullet_speed, ForceMode2D.Impulse);

        Destroy(Bullet, 3);
    }

    void SpreadShot()
    {
        GameObject Spread1;
        GameObject Spread2;
        GameObject Spread3;

        Spread1 = (Instantiate(spread1prefab, transform.position, transform.rotation)) as GameObject;

        Destroy(Spread1, 3);

        Spread2 = (Instantiate(spread2prefab, transform.position, transform.rotation)) as GameObject;

        Destroy(Spread2, 3);

        Spread3 = (Instantiate(spread3prefab, transform.position, transform.rotation)) as GameObject;

        Destroy(Spread3, 3);

    }

    void SlideShotR()
    {
        GameObject SliderR;

        sliderrandom = Random.Range(-9, 8);

        SliderR = (Instantiate(SliderRprefab, new Vector3(-22, sliderrandom), transform.rotation)) as GameObject;

        SliderR.GetComponent<Rigidbody2D>().transform.Rotate(new Vector3(0, 0, 90));

        Destroy(SliderR, 3);
    }

    void BurstBomb()
    {
        GameObject BurstBomb;

        BurstBomb = (Instantiate(BurstBombprefab, transform.position, transform.rotation)) as GameObject;

        Destroy(BurstBomb, 3);


    }

    void CrazyShot()
    {
        GameObject CrazyShot;

        CrazyShot = (Instantiate(Crazyshotprefab, transform.position, transform.rotation)) as GameObject;

        Destroy(CrazyShot, 3);

    }

}
