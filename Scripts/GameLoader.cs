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
    void Start()
    {
        if (MainMenuOptions.isLoading == true)
        {
            savedCookies = PlayerPrefs.GetInt("Saved Cookies");
            GlobalCookies.CookieCount = savedCookies;
            savedCash = PlayerPrefs.GetInt("Saved Cash");
            GlobalCash.CashCount = savedCash;
            savedBakers = PlayerPrefs.GetInt("Saved Bakers");
            GlobalBaker.numberOfBakers = savedBakers;
            savedShops = PlayerPrefs.GetInt("Saved Shops");
            GlobalShop.numberOfShops = savedShops;
            savedValue = PlayerPrefs.GetInt("SaveValue");
            SaveGame.saveValue = savedValue;
            savedPerSec = PlayerPrefs.GetInt("Saved PerSecond");
            GlobalBaker.bakePerSec = savedPerSec;
            soldPerSec = PlayerPrefs.GetInt("Saved PerSecond");
            GlobalShop.shopPerSec = soldPerSec;
            




        }
    }
}

 
