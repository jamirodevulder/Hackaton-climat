using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class MoneyHandler : MonoBehaviour
{
    //variabelen

    public float Money;
    public Text money;


    void Start()
    {
        Money = 500;
        MoneyText();
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (Money > 0)
            {
                TakeDamage();
            }
            else
            {
                print("Dead");
            }
        }
    }

    void TakeDamage()
    {

        Money -= 5;
        MoneyText();
    }

    void MoneyText()
    {
        money.text = Money.ToString();
    }


}