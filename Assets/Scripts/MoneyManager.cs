using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UIManager uimanager;

    void Start()
    {
        uimanager.UpdateMoneyTxt(money.ToString());
    }

    public void UpdateMoney(float moneyToAdd)
    {
        Debug.Log("update");

        if (money + moneyToAdd < 0)
        {
            Debug.Log("No alcanza");
            return;
        }
        money += moneyToAdd;
        uimanager.UpdateMoneyTxt(money.ToString());
    }
}