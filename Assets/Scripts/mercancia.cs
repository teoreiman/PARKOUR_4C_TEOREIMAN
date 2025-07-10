using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mercancia : MonoBehaviour
{
    public float costo;
    public MoneyManager moneyManager;

    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //resta de plata por compra
            moneyManager.UpdateMoney(-costo);
            Destroy(gameObject);
        }
    }
}