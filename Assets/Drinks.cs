using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drinks : Consumable
{
    public bool IsGummy;
    public float Thirst;
    public override string Usetext()
    {
        return base.Usetext() + ". " + IsItGummy() + " Gummy. You have a Thirst of " + Thirst;
    }
    public string IsItGummy()
    {
        if (IsGummy == true)
        {
            return ("Is Very");
        }
        else
        {
            return ("It's  not so");
        }
    }
    void Start()
    {
        Thirst = 5;
    }

    void Update()
    {

    }
}
