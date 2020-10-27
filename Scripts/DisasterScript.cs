using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisasterScript : MonoBehaviour
{
    public GameObject statusBox;
    public float cookieCheck;
    public int genChance;
    public bool disasterActive = false;
    public int cookieLoss;
    void Update()
    {
        cookieCheck = GlobalCookies.CookieCount / 100;
        if(disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
    }

    IEnumerator StartDisaster()
    {
        disasterActive = true;
        genChance = Random.Range(1, 200);
        if(cookieCheck >= genChance)
        {
            cookieLoss = Mathf.RoundToInt(GlobalCookies.CookieCount * 0.25f);
            statusBox.GetComponent<Text>().text = "You Lost " + cookieLoss + " Cookies in a Factory Fire";
            GlobalCookies.CookieCount -= cookieLoss;
            yield return new WaitForSeconds(0.5f);
            statusBox.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            statusBox.SetActive(false);
            statusBox.SetActive(true);
        }
        yield return new WaitForSeconds(10);
        disasterActive = false;

    }
}
