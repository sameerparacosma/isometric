﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionController : MonoBehaviour {

    // Use this for initialization
    Vector3 forward, right;
    private float movespeed =3.0f;

    void Start () {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
        { Move(); }
	}
    void Move()
    {
        Vector3 rightMovement = right * movespeed * Time.deltaTime * Input.GetAxis("Horizontal");
        Vector3 upMovement = forward * movespeed * Time.deltaTime * Input.GetAxis("Vertical");

        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);
        transform.forward = heading;
        transform.position += rightMovement;
        transform.position += upMovement;

    }
}
