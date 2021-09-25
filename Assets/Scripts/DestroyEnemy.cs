using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public Fight fight;
    public GameObject player;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        target = GameObject.FindWithTag("Player").transform;
        fight = player.GetComponent<Fight>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (fight.check == true && Vector3.Distance(transform.position,player.transform.position) < 30 )
        {
            transform.LookAt(target);
        }
    }

    private void OnDisable()
    {
        Destroy(gameObject);
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Obstcl"))
        {
            transform.position = new Vector3(transform.position.x - 5, transform.position.y, transform.position.z-5);
        }
    }
   
}
