using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{

    public static bool SellingCookie = false;

    public static int CashIncrease = 1;
    public int InternalIncrease;

    void Update()
    {
        CashIncrease = GlobalShop.shopPerSec;
        InternalIncrease = CashIncrease;
        if (SellingCookie == false)
        {
            SellingCookie = true;
            StartCoroutine(SellTheCookie());
        }
    }


    public IEnumerator SellTheCookie()
    {
        if (GlobalCookies.CookieCount <= 0)
        {
            GlobalCookies.CookieCount = 0;
            SellingCookie = false;
        }
        else
        {
            GlobalCash.CashCount += InternalIncrease;
            GlobalCookies.CookieCount -= GlobalShop.numberOfShops;
            yield return new WaitForSeconds(1);
            SellingCookie = false;
        }
        

    }
}