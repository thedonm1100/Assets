using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{

    public int saveGameCash;
    public static int saveValue = 10;
    public GameObject saveButton;
    public GameObject saveText;
    void Update()
    {
        saveText.GetComponent<Text>().text = "Cost: $" + saveValue;
        saveGameCash = GlobalCash.CashCount;
        if (saveGameCash >= saveValue)
        {
            saveButton.GetComponent<Button>().interactable = true;
        } else
        {
            saveButton.GetComponent<Button>().interactable = false;
        }
    }
    public void SaveTheGame()
    {
        GlobalCash.CashCount -= saveValue;
        PlayerPrefs.SetInt("Saved Cookies", GlobalCookies.CookieCount);
        PlayerPrefs.SetInt("Saved Cash", GlobalCash.CashCount);
        PlayerPrefs.SetInt("Saved Bakers", GlobalBaker.bakePerSec);
        PlayerPrefs.SetInt("Saved Shops", GlobalShop.numberOfShops);
        PlayerPrefs.SetInt("Saved PerSecond", GlobalBaker.bakePerSec);
        PlayerPrefs.SetInt("Sold PerSecond", GlobalShop.shopPerSec);
        saveValue *= 2;
        PlayerPrefs.SetInt("SaveValue", saveValue);
    }
}
