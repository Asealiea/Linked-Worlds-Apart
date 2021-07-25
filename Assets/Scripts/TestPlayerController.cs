﻿using UnityEngine;
using System.Collections;

public class TestPlayerController : MonoBehaviour
{
    public float speed = 6f;            //The speed that the player will move.
    public float turnSpeed = 60f;
    public float turnSmoothing = 15f;

    private Vector3 movement;
    private Vector3 turning;
    private Animator anim;
    private Rigidbody playerRigidbody;

    void Awake()
    {
        //Get references
        anim = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //Store input axes
        float lh = Input.GetAxisRaw("Horizontal");
        float lv = Input.GetAxisRaw("Vertical");


        Move(lh, lv);

        Animating(lh, lv);
    }

    void Move(float lh, float lv)
    {

        Vector3 moveVector = (transform.forward * lv) + (transform.right * lh);
        moveVector *= 1 * Time.deltaTime;

        transform.position += moveVector;


        if (lh != 0f || lv != 0f)
        {
            Rotating(lh, lv);
        }

    }

    void Rotating(float lh, float lv)
    {
        Vector3 targetDirection = new Vector3(lh, 0f, lv);

        Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up);

        Quaternion newRotation = Quaternion.Lerp(GetComponent<Rigidbody>().rotation, targetRotation, turnSmoothing * Time.deltaTime);

        GetComponent<Rigidbody>().MoveRotation(newRotation);
    }

    void Animating(float lh, float lv)
    {
        bool running = lh != 0f || lv != 0f;

        anim.SetBool("IsWalking", running);
    }
}
