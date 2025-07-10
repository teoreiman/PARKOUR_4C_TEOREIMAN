using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mercancia : MonoBehaviour
{
    public float cost;
    public MoneyManager moneyManager;

    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //alcualizar dinero por la compra
            moneyManager.UpdateMoney(-cost);
            Destroy(gameObject);
        }
    }
}