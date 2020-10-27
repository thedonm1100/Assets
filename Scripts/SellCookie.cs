﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCookie : MonoBehaviour
{

    public GameObject textBox;
    public GameObject statusBox;
    public AudioSource cashOne;
    public AudioSource cashTwo;
    public int generateTone;
    public AudioSource noCookie;

    public void clickTheButton()
    {
        generateTone = Random.Range(1, 3);
        if (GlobalCookies.CookieCount == 0)
        {
            noCookie.Play();
            statusBox.GetComponent<Text>().text = "Not Enough Cookies To Sell";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            if(generateTone == 1)
            {
                cashOne.Play();
            } 
            if (generateTone == 2)
            {
                cashTwo.Play();
            }
            GlobalCookies.CookieCount -= 1;
            GlobalCash.CashCount += 1;
        }
       
    }

}
