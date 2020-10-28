using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameLoader : MonoBehaviour
{

    public int savedCookies;
    public int savedCash;
    public int savedBakers;
    public int savedShops;
    public int savedValue;
    public int savedPerSec;
    public int soldPerSec;
    public int shopsValue;
    public int bakersValue;




    
    void Start()
    {
        if (MainMenuOptions.isLoading == true)
        {
            savedCookies = PlayerPrefs.GetInt("SavedCookies");
            GlobalCookies.CookieCount = savedCookies;
            savedCash = PlayerPrefs.GetInt("SavedCash");
            GlobalCash.CashCount = savedCash;
            savedBakers = PlayerPrefs.GetInt("SavedBakers");
            GlobalBaker.numberOfBakers = savedBakers;
            savedShops = PlayerPrefs.GetInt("SavedShops");
            GlobalShop.numberOfShops = savedShops;
            savedValue = PlayerPrefs.GetInt("SaveValue");
            SaveGame.saveValue = savedValue;
            savedPerSec = PlayerPrefs.GetInt("SavedPerSec");
            GlobalBaker.bakePerSec = savedPerSec;
            soldPerSec = PlayerPrefs.GetInt("SoldPerSec");
            GlobalShop.shopPerSec = soldPerSec;
            shopsValue = PlayerPrefs.GetInt("ShopValue");
            GlobalShop.shopValue = shopsValue;
            bakersValue = PlayerPrefs.GetInt("BakerValue");
            GlobalBaker.bakerValue = bakersValue;
           
            





        }

    }

}

