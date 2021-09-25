using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Image NoticeFight;
    public Joystick joystick;
    public Fight fight;

    public PlayerController plcnt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fight.check == true)
        {
            NoticeFight.gameObject.SetActive(true);
            joystick.gameObject.SetActive(false);
            
            plcnt.speed = 0;
        }
    }

    public void CloseFightNotic()
    {
        NoticeFight.gameObject.SetActive(false);
        joystick.gameObject.SetActive(true);
        plcnt.speed = 55;
        fight.check = false;
    }
    
}
