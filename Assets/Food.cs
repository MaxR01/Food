using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Consumable
{
    public bool IsGummy;
    public float Saturation;
    public override string Usetext()
    {
        return base.Usetext() + ". " + IsItGummy() + " Gummy. You have a saturation of " + Saturation;
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
    }
    void Update()
    {

    }
}
