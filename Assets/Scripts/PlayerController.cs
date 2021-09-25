using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool checkfight = false;
    public Joystick joystick;
    public Rigidbody player;
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = joystick.Vertical;
        horizontalInput = joystick.Horizontal;
        player.velocity = new Vector3(joystick.Horizontal * speed, player.velocity.z, joystick.Vertical * speed);
    }
    
}
